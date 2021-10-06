using System;
using System.Linq;
using MongoDB.Bson.Serialization.Serializers;
using RepeaterQTH.Data;
using System.Linq.Dynamic.Core;
namespace RepeaterQTH.Support
{
    public class Utility
    {
        public static string latLonToGridSquare(double? _lat, double? _lon)
        {
            if (_lat == null || _lon == null) return null;
            double lat = _lat.Value;
            double lon = _lon.Value;
            double adjLat,adjLon;
            char GLat,GLon;
            string nLat,nLon;
            char gLat,gLon;
            double rLat,rLon;
            string U = "ABCDEFGHIJKLMNOPQRSTUVWX";
            string L = U.ToLower();

            if (double.IsNaN(lat)) throw new Exception("lat is NaN");
            if (double.IsNaN(lon)) throw new Exception("lon is NaN");
            if (Math.Abs(Math.Abs(lat) - 90.0) < 0.01) throw new Exception("grid squares invalid at N/S poles");
            if (Math.Abs(lat) > 90) throw new Exception("invalid latitude: "+lat);
            if (Math.Abs(lon) > 180) throw new Exception("invalid longitude: "+lon);

            if (lat == 0.0 && lon == 0.0) return null;
            adjLat = lat + 90;
            adjLon = lon + 180;
            GLat = U[(int) (adjLat/10)];
            GLon = U[(int) (adjLon/20)];
            nLat = ""+(int)(adjLat % 10);
            nLon = ""+(int)((adjLon/2) % 10);
            rLat = (adjLat - (int)(adjLat)) * 60;
            rLon = (adjLon - 2*(int)(adjLon/2)) *60;
            gLat = L[(int)(rLat/2.5)];
            gLon = L[(int)(rLon/5)];
            return ""+GLon+GLat+nLon+nLat+gLon+gLat;
        }
        
        public static Repeater[] FilterRepeaters(Repeater[] repeaters, SearchData searchData )
        {
            
            // filter
                if (searchData.FM)
                {
                    repeaters = repeaters.Where(r => r.FMEnabled == true).ToArray();
                }
                if (searchData.DMR)
                {
                    repeaters = repeaters.Where(r => r.DMREnabled == true).ToArray();
                }
                if (searchData.DSTAR)
                {
                    repeaters = repeaters.Where(r => r.DStarEnabled == true).ToArray();
                }
                if (searchData.NXDN)
                {
                    repeaters = repeaters.Where(r => r.NXDNEnabled == true).ToArray();
                }
                if (searchData.P25)
                {
                    repeaters = repeaters.Where(r => r.P25Enabled == true).ToArray();
                }
                if (searchData.YSF)
                {
                    repeaters = repeaters.Where(r => r.YSFEnabled == true).ToArray();
                }
                if (searchData.AllStar)
                {
                    repeaters = repeaters.Where(r =>  r.AllStarId.HasValue && r.AllStarId.Value != 0).ToArray();
                }
                if (searchData.Echolink)
                {
                    repeaters = repeaters.Where(r =>  r.EcholinkNum.HasValue && r.EcholinkNum.Value != 0).ToArray();
                }
                if (searchData.IRLP)
                {
                    repeaters = repeaters.Where(r =>r.IRLPNum.HasValue && r.IRLPNum.Value != 0).ToArray();
                }
                return repeaters;
            }
            
    }
}