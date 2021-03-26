using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Models
{
    public class Attendee
    {
        public int Attendee_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public List<Event> Event { get; set; }

    }
}
}
