using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using RepeaterQTH.Support;

namespace RepeaterQTH.Data
{
  
    [BsonIgnoreExtraElements]
    public class Zipcode

    {
        public string zip { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

    }
    

}
