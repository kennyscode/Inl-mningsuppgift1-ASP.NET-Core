using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public Organizer Organizer { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public int Date { get; set; }
        public int Spots_available { get; set; }
        public List<Attendee> Attendee { get; set; }
    }
}
