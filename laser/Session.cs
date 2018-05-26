using System;
using Realms;
using System.Collections.Generic;
namespace laser
{
    public class Session:RealmObject
    {
        public IList<Player> Players { get; }         
        public Session()
        {
        }
    }
}
