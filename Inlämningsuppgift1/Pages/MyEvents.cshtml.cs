using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift1.Data;
using Inlämningsuppgift1.Models;

namespace Inlämningsuppgift1.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly Inlämningsuppgift1.Data.OKDbContext _context;

        public MyEventsModel(Inlämningsuppgift1.Data.OKDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public Attendee Attendee { get; set; }
        public string Message { get; set; }


        public void OnGetAsync(string handler = "")
        {
            Attendee = _context.Attendee.Where(a => a.AttendeeId == 1).Include(e => e.Events).FirstOrDefault();

            Message = handler;

            Event = Attendee.Events;


        }
    }
}
