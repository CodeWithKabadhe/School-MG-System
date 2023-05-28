using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Sujects")]
        public String SubjectNames { get; set; }
        [Display(Name = "Term")]
        public string TermName { get; set; }
        [Display(Name = "Total")]
        public int TotalMarks { get; set; }
        [Display(Name = "Grades")]

        public string Grade { get; set; }

        
    }
}
