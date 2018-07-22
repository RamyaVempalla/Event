using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Model.Events
{
    public class Admin
    {
        public List<Events> EventList { get; set; } = new List<Events>();
        public void AddEvent(int eventId, string eventName, string eventPlace, int eventFee)
        {
            EventList.Add(new Events() { Id = eventId, Name = eventName, Place = eventPlace, Fee = eventFee });
        }
        public List<Events> SeeEvents()
        {
            return EventList;
        }
    }
}
