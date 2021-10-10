using System;
using MongoDB.Bson.Serialization.Attributes;

namespace RepeaterQTH.Data
{
    [BsonIgnoreExtraElements]
    public class IPLocation
    {
        public DateTime updated { get; set; }
        public string ip { get; set; }
        public double? lat { get; set; }
        public double? lng { get; set; }
    }
}