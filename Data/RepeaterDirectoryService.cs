using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using System.Text.Json;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace K2GXT_Directory_2.Data
{
    public class RepeaterDirectoryService
    {
        private Repeater[] repeaters;
        //private MongoClient dbClient;
        private IMongoDatabase database;
        private IMongoCollection<Repeater> collection;

        public RepeaterDirectoryService()
        {
            MongoClient dbClient =
                new MongoClient(
                    "mongodb+srv://k2gxt:XrpAJULNNHICwQIs@cluster0.fv2i8.mongodb.net/test?authSource=admin&replicaSet=atlas-zytw02-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");
            database = dbClient.GetDatabase("directory");
            collection = database.GetCollection<Repeater>("repeater");
        }

        public Task<Repeater[]> GetRepeaterListAsync()
        {
        
            var filter = Builders<Repeater>.Filter.Empty;
            var sort = Builders<Repeater>.Sort.Ascending("Receive Frequency");
            IAsyncCursor<Repeater> repeatersAsDocs = collection.FindSync(filter,
                new FindOptions<Repeater, Repeater>()
                {
                    Sort = sort
                });
            repeaters = repeatersAsDocs.ToEnumerable().ToArray();
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
