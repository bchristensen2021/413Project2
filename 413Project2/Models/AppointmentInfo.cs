using System;
using System.ComponentModel.DataAnnotations;

namespace _413Project2.Models
{
    public class AppointmentInfo
    {
        [Key]
        [Required]
        public int AppId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }
        
        public string Phone { get; set; }

        //Thinking this field can hold what timeslot they clicked on
        public int TimeSlotId { get; set; }

        public TimeSlots TimeSlots { get; set; }
    }
}