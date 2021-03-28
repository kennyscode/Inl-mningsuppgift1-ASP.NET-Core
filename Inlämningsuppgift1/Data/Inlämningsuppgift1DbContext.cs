using Inlämningsuppgift1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Data
{
    public class OKDbContext : DbContext
    {
        public OKDbContext(DbContextOptions<OKDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }

        public void Seeding()
        {
            this.Database.EnsureCreated();

            if (Event.Any() ||
                Attendee.Any() ||
                Organizer.Any())
            {
                return;
            }


            Attendee.AddRange(new List<Attendee>()
            {
                new Attendee() { Name = "BestUser123", Email = "hehhe@hotmail.com", Phone_number= "0739615514"},
                new Attendee() { Name = "2ndUser123", Email = "hohho@hotmail.com", Phone_number= "0739615512"}
            });
            SaveChanges();

            Organizer.AddRange(new List<Organizer>()
            {
                new Organizer() { Name = "BestEventHandler", Email = "hihhi@hotmail.com", Phone_number= "0739615511"},
                new Organizer() { Name = "2ndOrganizer123", Email = "hahha@hotmail.com", Phone_number= "0739615510"}

            });
            SaveChanges();

            Event.AddRange(new List<Event>()
            {
                new Event() { Description= "TheBestEventEver", Organizer = Organizer.Where(x => x.Name=="BestEventHandler").FirstOrDefault(), Place= "Halmstad", Adress= "wall street 12", Date= 210404, Spots_available= 440 },
                new Event() { Description= "StarGazing", Organizer = Organizer.Where(x => x.Name=="BestEventHandler").FirstOrDefault(), Place= "Los Angeles", Adress= "wall street 10", Date= 210505, Spots_available= 144 },
                new Event() { Description= "VolleybollMatch", Organizer = Organizer.Where(x => x.Name=="2ndOrganizer123").FirstOrDefault(), Place= "Båstad", Adress= "wall street 1", Date= 210606, Spots_available= 255 },
                new Event() { Description= "Armbrytning", Organizer = Organizer.Where(x => x.Name=="2ndOrganizer123").FirstOrDefault(), Place= "Halmstad", Adress= "wall street 2", Date= 220101, Spots_available= 100 }


            });
            SaveChanges();

        }
    }
}
