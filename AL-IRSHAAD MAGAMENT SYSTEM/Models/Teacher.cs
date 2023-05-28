using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name of Teacher")]
        public string F_Name { get; set; }

        [Required]
        [Display(Name = "Phone of Teacher")]
        public int phone { get; set; }

        [Required]
        [Display(Name = "Address of Teacher")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Shift In Teacher")]
        public string Shift { get; set; }
        [Display(Name = "Subject In Teacher")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Date Teacher")]
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Display(Name = "Premission")]
        public bool AdminPermition { get; set; }
    }
}
