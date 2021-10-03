using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using RepeaterQTH.Support;

namespace RepeaterQTH.Data
{
   

    [BsonIgnoreExtraElements]
    public class Counties

    {
        public string state_name;
        public string county;

    }
    

}
