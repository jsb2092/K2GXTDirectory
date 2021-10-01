using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using K2GXT_Directory_2.Data;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace K2GXT_Directory_2.Data
{
    public class RepeaterDirectoryService
    {
        private Repeater[] repeaters;

        public List<double> Tones = new()
        {
            67, 97.4, 141.3, 177.3, 213.8,
            69.3, 100, 146.2, 179.9, 218.1,
            71.9, 103.5, 150, 183.5, 221.3,
            74.4, 107.2, 151.4, 186.2, 225.7,
            77, 110.9, 156.7, 189.9, 229.1,
            79.7, 114.8, 159.8, 192.8, 233.6,
            82.5, 118.8, 162.2, 196.6, 237.1,
            85.4, 123, 165.5, 199.5, 241.8,
            88.5, 127.3, 167.9, 203.5, 245.5,
            91.5, 131.8, 171.3, 206.5, 250.3,
            94.8, 136.5, 173.8, 210.7, 254.1
        };
      

        private IMongoDatabase database;
        private IMongoCollection<Repeater> collection;
        private IMongoCollection<Counties> countiesCollection;

        public RepeaterDirectoryService()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Repeater)))
            {
                // Initialize Mongo Mappings
                BsonClassMap.RegisterClassMap<Repeater>(cm =>
                {
                    cm.AutoMap();
                    cm.MapMember(x => x.Tone).SetDefaultValue("CSQ");
                    // this doesn't work, as all the objects get the same damn object, this would work for 
                    // primatives though.
                    // cm.GetMemberMap(x => x).SetDefaultValue(new LocationInfo());
                });

            }
            
            // get the data from a json file that looks like:
            //{
            //    "connectionString": "<your connection string>"
            //}

            using (StreamReader r = new StreamReader("connection.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                MongoClient dbClient =
                    new MongoClient(items["connectionString"]);
                 database = dbClient.GetDatabase("directory");
                collection = database.GetCollection<Repeater>("repeater");
                countiesCollection = database.GetCollection<Counties>("usa_counties");
            }


        }

        public Task<Repeater[]> GetRepeaterListAsync(int limit = 100)
        {
            return GetRepeaterListByLocation(43, -77.6, limit);
        }

        public Task<Repeater[]> GetRepeaterListByLocation(double lat, double lng, int limit = 100)
        {
            var geoPoint = new BsonDocument
            {
                {"type", "Point"},
                { "coordinates", new BsonArray(new double[] {lng, lat}) }
            };
            var geoNearOptions = new BsonDocument
            {
                {"spherical", true},
                {"near", geoPoint},
                {"distanceField", "distance"}
            };
            var stage = new BsonDocumentPipelineStageDefinition<Repeater, Repeater>(new BsonDocument
            {
                {"$geoNear", geoNearOptions}
            });
            var sort = Builders<Repeater>.Sort.Ascending("distance");
            var result = collection.Aggregate().AppendStage(stage).Limit(limit).Sort(sort).ToListAsync().Result;
            repeaters = result.ToArray();
            return Task.FromResult(repeaters);
        }
        
        public async Task<Repeater> GetRepeaterAsync(string id)
        {
            // try to get the data from the list first, if we can't read from the db
            try
            {
                return repeaters.AsQueryable().First(repeater => repeater._id == id);;
            }
            catch
            {
                var filter = new BsonDocument()
                    .Add("_id", ObjectId.Parse(id));
                 return  await collection.Find(filter).Limit(1).FirstAsync();
            }
        }

        public async Task<Repeater[]> GetAllRepeaters()
        {
            var filter = new BsonDocument();
            var sort = Builders<Repeater>.Sort.Ascending("Receive Frequency");
            var r =  collection.FindSync(filter,    
                new FindOptions<Repeater, Repeater>()
            {
                Sort = sort
            });
            return r.ToList().ToArray();    
        }

        public async Task<Repeater[]> GetRepeatersByCallSignAsync(string callsign)
        {
            // try to get the data from the list first, if we can't read from the db
            try
            {
                return repeaters.AsQueryable().Where(repeater => repeater.CallSign == callsign).ToArray();
            }
            catch
            {
                var filter = new BsonDocument()
                    .Add("Callsign", callsign);
                var r = await collection.FindAsync(filter);
                return r.ToList().ToArray();
            }
        }

        public Task<Counties[]> getCounties()
        {
            Counties[] counties;
            var filter = Builders<Counties>.Filter.Empty;
            var sort = Builders<Counties>.Sort.Ascending("state_name");
            IAsyncCursor<Counties> countiesAsDocs = countiesCollection.FindSync(filter,
                new FindOptions<Counties, Counties>()
                {
                    Sort = sort
                });
            counties = countiesAsDocs.ToEnumerable().ToArray();
            foreach (var r in repeaters)
            {
                r.Location ??= new LocationInfo();
            }
            return Task.FromResult(counties);
        }
        
        public async Task<bool> SaveRepeater(Repeater repeater)
        {
            try
            {
                await collection.ReplaceOneAsync(r => r._id == repeater._id, repeater);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
