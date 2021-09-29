using Darnton.Blazor.Leaflet.LeafletMap;

namespace K2GXT_Directory_2.Data
{
    public class MapStateViewModel
    {
        public double MapCentreLatitude { get; set; }
        public double MapCentreLongitude { get; set; }
        public int Zoom { get; set; }
        public Point MapContainerSize { get; set; }
        public Bounds MapViewPixelBounds { get; set; }
        public Point MapLayerPixelOrigin { get; set; }
    }
}
