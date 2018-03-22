using System;
using Google.Maps;
using Google.Maps.StaticMaps;
using Settings.GoogleMaps;

namespace BusinessLogic.MapsService
{
    public class GoogleMapsService : IMapsService
    {
        public GoogleMapsService()
        {
            //Test in constructor 
            GoogleSigned.AssignAllServices(new GoogleSigned(Config.GoogleMapsApiKey));
        }

        public Uri GetLocationFromAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentNullException("Address is null");

            var map = new StaticMapRequest
            {
                Center = new Location(address),
                Size = new MapSize(400, 400),
                Zoom = 14
            };

            return map.ToUri();
        }
    }
}