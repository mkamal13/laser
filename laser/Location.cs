using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Realms;

namespace laser
{
    public class Location : RealmObject
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Radius { get; set; }

        public int CapturePoints { get; set; }

        public IList<Player> PlayersAtLocation { get; }
        public Event LocationEnter { get; set; }
        public Event LocationExit { get; set; }
        public Event LocationRemove { get; set; }

        public Location()
        { }

        public Location(double Latitude, double Longitude, int Radius)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Radius = Radius;
        }

        public bool IsPlayerInsideLocation(Player player)
        {
            double lat = this.Latitude-player.Latitude;
            double lon = this.Longitude - player.Longitude;
            double distance = Math.Sqrt(lat*lat+lon*lon);
            return distance <= Radius;
        }

        public void Update(Player player)
        {
            if (IsPlayerInsideLocation(player))
            {
                if (!PlayersAtLocation.Contains(player))
                {
                    PlayersAtLocation.Add(player);
                    LocationEnter.TriggerEvent(null, player);
                }
            }
            else
            {
                bool was_at_location = PlayersAtLocation.Remove(player);
                if (was_at_location)
                {
                    LocationExit.TriggerEvent(null, player);
                }    
            }
        }
    }

}
