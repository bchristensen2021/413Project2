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
                new TimeSlots { TimeSlotName = "Monday 8am", TimeSlotId = 1, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 9am", TimeSlotId = 2, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 10am", TimeSlotId = 3, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 11am", TimeSlotId = 4, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 12pm", TimeSlotId = 5, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 1pm", TimeSlotId = 6, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 2pm", TimeSlotId = 7, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 3pm", TimeSlotId = 8, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 4pm", TimeSlotId = 9, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 5pm", TimeSlotId = 10, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 6pm", TimeSlotId = 11, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 7pm", TimeSlotId = 12, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Monday 8pm", TimeSlotId = 13, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 8am", TimeSlotId = 14, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 9am", TimeSlotId = 15, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 10am", TimeSlotId = 16, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 11am", TimeSlotId = 17, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 12pm", TimeSlotId = 18, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 1pm", TimeSlotId = 19, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 2pm", TimeSlotId = 20, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 3pm", TimeSlotId = 21, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 4pm", TimeSlotId = 22, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 5pm", TimeSlotId = 23, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 6pm", TimeSlotId = 24, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 7pm", TimeSlotId = 25, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Tuesday 8pm", TimeSlotId = 26, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 8am", TimeSlotId = 27, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 9am", TimeSlotId = 28, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 10am", TimeSlotId = 29, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 11am", TimeSlotId = 30, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 12pm", TimeSlotId = 31, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 1pm", TimeSlotId = 32, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 2pm", TimeSlotId = 33, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 3pm", TimeSlotId = 34, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 4pm", TimeSlotId = 35, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 5pm", TimeSlotId = 36, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 6pm", TimeSlotId = 37, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 7pm", TimeSlotId = 38, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Wednesday 8pm", TimeSlotId = 39, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 8am", TimeSlotId = 40, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 9am", TimeSlotId = 41, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 10am", TimeSlotId = 42, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 11am", TimeSlotId = 43, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 12pm", TimeSlotId = 44, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 1pm", TimeSlotId = 45, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 2pm", TimeSlotId = 46, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 3pm", TimeSlotId = 47, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 4pm", TimeSlotId = 48, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 5pm", TimeSlotId = 49, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 6pm", TimeSlotId = 50, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 7pm", TimeSlotId = 51, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Thursday 8pm", TimeSlotId = 52, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 8am", TimeSlotId = 53, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 9am", TimeSlotId = 54, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 10am", TimeSlotId = 55, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 11am", TimeSlotId = 56, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 12pm", TimeSlotId = 57, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 1pm", TimeSlotId = 58, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 2pm", TimeSlotId = 59, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 3pm", TimeSlotId = 60, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 4pm", TimeSlotId = 61, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 5pm", TimeSlotId = 62, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 6pm", TimeSlotId = 63, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 7pm", TimeSlotId = 64, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Friday 8pm", TimeSlotId = 65, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 8am", TimeSlotId = 66, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 9am", TimeSlotId = 67, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 10am", TimeSlotId = 68, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 11am", TimeSlotId = 69, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 12pm", TimeSlotId = 70, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 1pm", TimeSlotId = 71, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 2pm", TimeSlotId = 72, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 3pm", TimeSlotId = 73, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 4pm", TimeSlotId = 74, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 5pm", TimeSlotId = 75, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 6pm", TimeSlotId = 76, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 7pm", TimeSlotId = 77, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Saturday 8pm", TimeSlotId = 78, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 8am", TimeSlotId = 79, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 9am", TimeSlotId = 80, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 10am", TimeSlotId = 81, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 11am", TimeSlotId = 82, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 12pm", TimeSlotId = 83, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 1pm", TimeSlotId = 84, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 2pm", TimeSlotId = 85, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 3pm", TimeSlotId = 86, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 4pm", TimeSlotId = 87, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 5pm", TimeSlotId = 88, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 6pm", TimeSlotId = 89, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 7pm", TimeSlotId = 90, TimeSlotAvailable = true },
                new TimeSlots { TimeSlotName = "Sunday 8pm", TimeSlotId = 91, TimeSlotAvailable = true }


                );
        }   

        }
}