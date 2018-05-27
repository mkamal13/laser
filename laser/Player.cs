using System;
using Realms;
namespace laser
{
    public class Player:RealmObject
    {  
        public RealmInteger<int> Health { get; set; }
        public string name { get; set;}
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Player()
        {
        }
    }
}
