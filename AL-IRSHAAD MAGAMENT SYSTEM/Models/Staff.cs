using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Staff
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name of Staff")]
        public string Full_Name { get; set; }

        [Required]
        [Display(Name = "Phone of Staff")]
        public int Phone { get; set; }

        [Required]
        [Display(Name = "Shift In Staff")]
        public string shift { get; set; }

        [Display(Name = "Date")]
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Address of Staff")]
        public string Address { get; set; }

        [Display(Name = "perimisson")]
        public bool AdminPermition { get; set; }
    }
}
