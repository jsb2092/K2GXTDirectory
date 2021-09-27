using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using K2GXT_Directory_2.Support;

namespace K2GXT_Directory_2.Data
{
   

    [BsonIgnoreExtraElements]
    public class Counties

    {
        public string state_name;
        public string county;

    }
    

}
