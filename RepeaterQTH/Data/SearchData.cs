using System.Collections.Generic;

namespace RepeaterQTH.Data
{
    public class SearchData
    {
        public string activeType { get; set; }
        public string zipcode { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public int range { get; set; } = 50;
        public string rangeUnit { get; set; } = "KM";
        public string state { get; set; } = "Alabama";
        public bool FM { get; set; }
        public bool DMR { get; set; }

        public bool DSTAR { get; set; }
        public bool NXDN { get; set; }

        public bool P25 { get; set; }
        public bool YSF { get; set; }

        public bool AllStar { get; set;  }
        public bool Echolink {  get; set; }
        public bool IRLP { get; set;  }

        public List<string> AvailableBands { get; set; } = new List<string> { "10m", "6m", "2m", "1.25m", "70cm", "33cm", "23cm"};

        public List<string> SelectedBands { get; set; } = new List<string> {"All"};

    }
}