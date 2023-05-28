using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Student__Reggs
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name of Student")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Name of Mother")]
        public string MotherName { get; set; }

        [Required]
        [Display(Name = "Phone of Parent")]
        public int Phone { get; set; }

        [Required]
        [Display(Name = "Address of Student")]
        public string Address { get; set; }

        [Display(Name = "Date Of Register")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Premission ")]
        public bool AdminPermition { get; set; }

        [Display(Name = "Brith Date")]
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
    }
}
