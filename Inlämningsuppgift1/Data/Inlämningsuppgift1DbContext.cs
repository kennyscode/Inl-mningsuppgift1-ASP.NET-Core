using Inlämningsuppgift1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Data
{
    public class UppgiftDbContext : DbContext
    {
        public UppgiftDbContext(DbContextOptions<UppgiftDbContext> options)
            : base(options)
        {
        }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Attendee> Attendee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
        }

        public void Seeding()
        {
            Database.EnsureCreated();

            if (Event.Any() ||
                Attendee.Any() ||
                Organizer.Any())
            {
                return;
            }


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
                new Event { Title = "BestEventEver", Organizer = Organizers[1], Description= "0739615511", Place= "Halmstad", Adress= "wall street 12", Date= 21-04-04, Spots_avaible= 400, },
                new Event { Title = "2ndBestEventEver", Organizer = Organizers[1], Description= "0739615522", Place= "Los Angeles", Adress= "wall street 11", Date= 21-02-04, Spots_avaible= 204, },
                new Event { Title = "VolleybollMatch", Organizer = Organizers[1], Description= "0739612121", Place= "Båstad", Adress= "Storgatan 14", Date= 21-08-04, Spots_avaible= 144, },
                new Event { Title = "Armbrytning", Organizer = Organizers[1], Description= "0722612121", Place= "Halmstad", Adress= "Hamngatan 1", Date= 22-01-01, Spots_avaible= 40, }
            };
            AddRange(Event);
            SaveChanges();

        }
    }
}
