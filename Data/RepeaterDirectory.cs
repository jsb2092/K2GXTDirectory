using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using K2GXT_Directory_2.Support;

namespace K2GXT_Directory_2.Data
{
    [BsonIgnoreExtraElements]
    public class LocationInfo
    {
     
        public string type { get; set; }
        public double?[] coordinates { get; set; }
        public LocationInfo () 
        {
            type = "point";
            coordinates = new double?[] {null, null} ;
  
        }
    }


    [BsonIgnoreExtraElements]
    public class Repeater : ICloneable

    {
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public DateTime Date { get; set; }

        [BsonElement("Callsign")] public string CallSign { get; set; }

        [BsonElement("Receive Frequency")] public double RxFreq { get; set; }

        [BsonElement("Transmit Frequency")] public double TxFreq { get; set; }

        public double? CTCSS { get; set; }

        [BsonElement("Tone Mode")] public string Tone { get; set; }

        [BsonElement("Rx CTCSS")] public double? RxCTCSS { get; set; }

        [BsonElement("Name")] public string Description { get; set; }

        public string State { get; set; }
        public string County { get; set; }

        [BsonElement("Location")]
        public LocationInfo Location { get; set; }

        private string _gridSquare;
        [BsonElement("GridSquare")] 
        public string GridSquare
        {
            get => Location?.coordinates[0] != null ? Utility.latLonToGridSquare(Location.coordinates[1], Location.coordinates[0]) : _gridSquare;
            set => _gridSquare = value;
        }

        public string Offset => (TxFreq - RxFreq > 0 ? "+" : "") + $"{(TxFreq - RxFreq):0.0}" + " MHz";

    }
    

}
