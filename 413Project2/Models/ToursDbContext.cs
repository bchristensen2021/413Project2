using System;
using Microsoft.EntityFrameworkCore;

namespace _413Project2.Models
{
    public class ToursDbContext : DbContext
    {
        //Constructor
        public ToursDbContext(DbContextOptions<ToursDbContext> options) : base (options)
        {

        }

        public DbSet <AppointmentInfo> AppointmentInfo { get; set; }
        public DbSet <TimeSlots> TimeSlots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = Tours.sqlite");
            }
        }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlots>().HasData(
                new TimeSlots { TimeSlotId = 1, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 2, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 3, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 4, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 5, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 6, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 7, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 8, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 9, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 10, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 11, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 12, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 13, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 14, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 15, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 16, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 17, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 18, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 19, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 20, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 21, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 22, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 23, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 24, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 25, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 26, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 27, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 28, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 29, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 30, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 31, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 32, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 33, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 34, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 35, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 36, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 37, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 38, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 39, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 40, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 41, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 42, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 43, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 44, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 45, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 46, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 47, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 48, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 49, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 50, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 51, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 52, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 53, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 54, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 55, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 56, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 57, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 58, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 59, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 60, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 61, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 62, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 63, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 64, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 65, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 66, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 67, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 68, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 69, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 70, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 71, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 72, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 73, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 74, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 75, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 76, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 77, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 78, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 79, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 80, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 81, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 82, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 83, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 84, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 85, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 86, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 87, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 88, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 89, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 90, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotId = 91, TimeSlotAvailable = true }


                );
        }   

        }
}