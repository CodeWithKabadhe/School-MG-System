using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class FEE
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        [Display(Name = "PAID ")]
        public bool Payer { get; set; }
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        [ForeignKey(" Class")]
        public int CLassid { get; set; }
        public Class Class { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
