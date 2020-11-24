using GoogleMapsComponents.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForceT.Client.Pages.Utile.Models
{
    public class GeocoderResult
    {
        public List<string> types { get; set; }
        public string formatted_address { get; set; }
        public List<address_component> address_components { get; set; }
        public bool partial_match { get; set; }
        public string place_id { get; set; }
        public List<string> postcode_localities { get; set; }
        public geometry geometry_prop { get; set; }
    }
    public class address_component
    {
        public string short_name { get; set; }
        public string long_name { get; set; }
        public List<string> postcode_localities { get; set; }
        public List<string> types { get; set; }
    }
    public class geometry
    {
        public LatLngLiteral location { get; set; }
        public string location_type { get; set; }
        public LatLngBoundsLiteral viewport { get; set; }
        public LatLngBoundsLiteral bounds { get; set; }
    }
}
