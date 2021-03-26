using Inlämningsuppgift1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Data
{
    public class Inlämningsuppgift1DbContext : DbContext
    {
        public Inlämningsuppgift1DbContext(DbContextOptions<Inlämningsuppgift1DbContext> options)
            : base(options)
        {
        }

        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }

        public void Seeding()
        {
            Database.EnsureCreated();

            RemoveRange(Organizer);
            RemoveRange(Event);
            RemoveRange(Attendee);

            List<Attendee> Attendees = new List<Attendee>
            {
                new Attendee { Name = "BestUser123", Email = "hehhe@hotmail.com", Phone_number= "0739615514"},
                new Attendee { Name = "2ndUser123", Email = "hohho@hotmail.com", Phone_number= "0739615512"}

            };
            AddRange(Attendee);
            SaveChanges();

            List<Organizer> Organizers = new List<Organizer>
            {
                new Organizer { Name = "BestOrganizer123", Email = "hihhi@hotmail.com", Phone_number= "0739615511"},
                new Organizer { Name = "2ndOrganizer123", Email = "hahha@hotmail.com", Phone_number= "0739615510"}

            };
            AddRange(Organizer);
            SaveChanges();

            List<Event> Events = new List<Event>
            {
                new Event { Title = "BestOrganizer123", Organizer = Organizers[1], Description= "0739615511", Place= "Halmstad", Adress= "wall street", Date= 21-04-04, Spots_avaible= 204, },
                new Event { Title = "2ndOrganizer123", Organizer = Organizers[1], Description= "0739615522", Place= "Halmstad", Adress= "wall street", Date= 21-04-04, Spots_avaible= 204, },

            };
            AddRange(Organizer);
            SaveChanges();

        }
    }
}
