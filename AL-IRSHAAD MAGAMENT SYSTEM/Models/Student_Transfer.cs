using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Student_Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string FullName { get; set; }

        public string SchoolFrom { get; set; }
        [Required]

        public string SchoolTo { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        [Display(Name = "AQBALID")]
        public bool AdminPermition { get; set; }
    }
}
