using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace RepeaterQTH.Data.Services
{
    public class LocationService
    {
        private IMongoDatabase database;
        private IMongoCollection<Counties> countiesCollection;
        private IMongoCollection<Zipcode> zipcodeCollection;
        private IMongoCollection<State> stateCollection;
        private IMongoCollection<IPLocation> ipCacheCollection;

        public LocationService()
        {
            using (StreamReader r = new StreamReader("connection.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                MongoClient dbClient =
                    new MongoClient(items["connectionString"]);
                database = dbClient.GetDatabase("directory");
                countiesCollection = database.GetCollection<Counties>("usa_counties");
                zipcodeCollection = database.GetCollection<Zipcode>("zipcodes");
                stateCollection = database.GetCollection<State>("usa_state_location");
                ipCacheCollection = database.GetCollection<IPLocation>("ip_cache");
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
            /* foreach (var r in repeaters)
             {
                 r.Location ??= new LocationInfo();
             }*/
            return Task.FromResult(counties);
        }
        
          
        
        public async Task<Zipcode> getLatLngForZip(string zip)
        {
            zip = zip.Trim();
            var filter = new BsonDocument()
                .Add("zip", zip);
            return await zipcodeCollection.Find(filter).Limit(1).FirstAsync();
       
        }
        
        public async Task<State> getLatLngForState(string state)
        {
            var filter = new BsonDocument()
                .Add("state", state);
            return await stateCollection.Find(filter).Limit(1).FirstAsync();
       
        }
        
           
        public async Task insertIPCache(IPLocation ipLocation)
        {   
            var filter = new BsonDocument()
                .Add("ip", ipLocation.ip);
            var updateOptions = new FindOneAndReplaceOptions<IPLocation>() { IsUpsert = true };
            await ipCacheCollection.FindOneAndReplaceAsync(filter, ipLocation, updateOptions);

        }
        
        public async Task<IPLocation> findIPCache(string ip)
        {
            var filter = new BsonDocument()
                .Add("ip", ip);
            try
            {
                var ipResult = await ipCacheCollection.Find(filter).Limit(1).FirstAsync();
                return ipResult;
            }
            catch
            {
                return null;
            }
        }

    }
}
