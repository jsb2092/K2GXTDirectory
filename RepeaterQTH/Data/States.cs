using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using RepeaterQTH.Support;

namespace RepeaterQTH.Data.Services
{
  
    [BsonIgnoreExtraElements]
    public class State

    {
        public string state { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

    }
    

}
