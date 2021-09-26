using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace K2GXT_Directory_2.Data
{


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

        [BsonElement("Name")] public string Location { get; set; }

        public string County { get; set; }

        public double Latitude { get; set; }

        public double Longitute { get; set; }

        public string GridSquare { get; set; }

        public string Offset => (TxFreq - RxFreq > 0 ? "+" : "") + $"{(TxFreq - RxFreq):0.0}" + " MHz";

    }
}
