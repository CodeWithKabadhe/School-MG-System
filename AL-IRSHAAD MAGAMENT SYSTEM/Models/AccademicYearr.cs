using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAD_SCHOOL_BOYSS.Models
{
    public class AccademicYearr
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string TOClass { get; set; }
        public string ClassNow { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Display(Name = "Premission")]
        public bool AdminPermition { get; set; }
    }
}
