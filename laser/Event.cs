using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace laser
{
    public class Event : RealmObject
    {
        public string AnnouncePattern { get; set; }

        public Event() { }

        /*
         * Invoking TriggerEvent() will create announcement log entry, announcement sounds and trigger any Effects.
         */
        public void TriggerEvent(Player source, Player target)
        {
            string text = FormatAnnouncement(source, target);
           
        }

        public string FormatAnnouncement(Player source, Player target)
        {
            string output = AnnouncePattern;
            output = output.Replace("[source]", source.name);
            output = output.Replace("[target]", target.name);
            return output;
        }

        public void ApplyEffects()
        { }
    }
}
