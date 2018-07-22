using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Model.Events
{
    public class User : Admin
    {
        public new List<Events> SeeEvents()
        {
            //foreach (var events in EventList)
            //{
            //    Console.WriteLine(events.Id + "." + events.Name + " " + events.Place + " " + events.Fee);
            //}
            return EventList;
        }
    }
}
