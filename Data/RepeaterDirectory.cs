using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace K2GXT_Directory_2.Data
{


    [BsonIgnoreExtraElements]
    public class Repeater
    {
        
        [BsonRepresentation(BsonType.ObjectId)] 
        public string _id { get; set; }
        public DateTime Date { get; set; }

        [BsonElement("Callsign")]
        public string CallSign { get; set; }
        
        [BsonElement("Receive Frequency")]
        public double RFreq { get; set; }
        
        [BsonElement("Transmit Frequency")]
        public double TFreq { get; set; }

        public double? CTCSS { get; set; }
        
        [BsonElement("Tone Mode")]
        public string Tone { get; set; }
        
        [BsonElement("Rx CTCSS")]
        public double? RxCTCSS { get; set; }

        [BsonElement("Name")]
        public string Location { get; set; }
        
        public string County { get; set; }

        public double Latitude { get; set; }

        public double Longitute { get; set; }
        
        public string GridSquare { get; set; }
        
        public string Offset => (TFreq - RFreq >0 ? "+":"") + $"{(TFreq - RFreq):0.0}" + " MHz";
    }
}
