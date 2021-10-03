using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using RepeaterQTH.Support;

namespace RepeaterQTH.Data
{
    [BsonIgnoreExtraElements]
    public class LocationInfo
    {
     
        
        public string type { get; set; }
        
        [Required]
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

        private string _callsign;
        [BsonElement("Callsign")] [Required] 
      
        
        public string CallSign { get => _callsign?.ToUpper(); set=>_callsign = value.ToUpper(); }

        [BsonElement("Receive Frequency")]
        [Required]
        [Range(1, 100000, ErrorMessage = "Please select a valid Rx frequency")]
        public double RxFreq { get; set; }

        [BsonElement("Transmit Frequency")]
        [Required]
        public double TxFreq { get; set; }

        public double? CTCSS { get; set; }

        [BsonElement("Tone Mode")] public string Tone { get; set; }

        [BsonElement("Rx CTCSS")] public double? RxCTCSS { get; set; }

        [BsonElement("Name")] public string Description { get; set; }

        public string State { get; set; }
        public string County { get; set; }

        [BsonElement("Location")] public LocationInfo Location { get; set; }

        private string _gridSquare;

        [BsonElement("GridSquare")]
        public string GridSquare
        {
            get => Location?.coordinates[0] != null
                ? Utility.latLonToGridSquare(Location.coordinates[1], Location.coordinates[0])
                : _gridSquare;
            set => _gridSquare = value;
        }

        public string Offset => (TxFreq - RxFreq > 0 ? "+" : "") + $"{(TxFreq - RxFreq):0.0}" + " MHz";

        [BsonIgnore]
        public string FMEnabledString
        {
            get => FMEnabled ? "Enabled" : "Disabled";
            set => FMEnabled = value == "Enabled";
        }

        public bool FMEnabled { get; set; }
        public int? AllStarId { get; set; }
        public int? EcholinkNum { get; set; }
        public string EcholinkCall { get; set; }
        public int? IRLPNum { get; set; }

        [BsonIgnore]
        public string DMREnabledString
        {
            get => DMREnabled ? "Enabled" : "Disabled";
            set => DMREnabled = value == "Enabled";
        }

        public bool DMREnabled { get; set; }
        public int DMRColorCode { get; set; }

        public string DStarType { get; set; }
        public int? DMRId { get; set; }

        [BsonIgnore]
        public string YSFEnabledString
        {
            get => YSFEnabled ? "Enabled" : "Disabled";
            set => YSFEnabled = value == "Enabled";
        }

        public bool YSFEnabled { get; set; }
        public int YSFDGUp { get; set; }
        public int YSFDGDown { get; set; }
        public int YSFBandwidth { get; set; }

        [BsonIgnore]
        public string DStarEnabledString
        {
            get => DStarEnabled ? "Enabled" : "Disabled";
            set => DStarEnabled = value == "Enabled";
        }

        public bool DStarEnabled { get; set; }

        [BsonIgnore]
        public string P25EnabledString
        {
            get => P25Enabled ? "Enabled" : "Disabled";
            set => P25Enabled = value == "Enabled";
        }

        public bool P25Enabled { get; set; }

        public int? P25Nac { get; set; }

        [BsonIgnore]
        public string NXDNEnabledString
        {
            get => NXDNEnabled ? "Enabled" : "Disabled";
            set => NXDNEnabled = value == "Enabled";
        }

        public bool NXDNEnabled { get; set; }
        public int? NXDNRAN { get; set; }
        public int? NXDNBandwidth { get; set; }


        public int? CoverageRadiusKM { get; set; }

        private string _isOpenString;
        public string isOpenString
        {
            get => _isOpenString ?? "Open";
            set => _isOpenString = value ?? "Open"; }

        public bool Active { get; set; }

        public Repeater()
        {
            Tone = "CSQ";
            isOpenString = "Open";
            Location = new LocationInfo();
        }

    }

    public class RepeaterValidator : AbstractValidator<Repeater>
    {
        public RepeaterValidator()
        {

            RuleFor(r => r.CallSign)
                .NotEmpty().WithMessage("You must enter a callsign")
                .MinimumLength(4).WithMessage("Callsign must be a mininum of 4 characters");
            
            RuleFor(r => r.RxFreq)
                .NotNull().WithMessage("You must have an Rx Frequency")
                .GreaterThan(0).WithMessage("Please enter a valid Rx frequency");
            RuleFor(r => r.TxFreq)
                .NotNull().WithMessage("You must have an Tx Frequency")
                .GreaterThan(0).WithMessage("Please enter a valid Tx frequency");
            
            RuleFor(r => r.Location.coordinates[1])
                .NotNull().WithMessage("You must have an Latitude")
                .GreaterThanOrEqualTo(-90).WithMessage("Latitude must be greater than -90")
                .LessThanOrEqualTo(90).WithMessage("Latitude must be less than 90");
            
            RuleFor(r => r.Location.coordinates[0])
                .NotNull().WithMessage("You must have an Longitude")
                .GreaterThanOrEqualTo(-180).WithMessage("Longitude must be greater than -180")
                .LessThanOrEqualTo(180).WithMessage("Longitude must be less than 180");

            RuleFor(r => r.State)
                .NotEmpty().WithMessage("Please select a state");


        }
    }

}
