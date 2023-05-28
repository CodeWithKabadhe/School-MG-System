using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class Class
    {
        [Key]
        public int id { get; set; }
        public string ClassName { get; set; }

        public string Subject { get; set; }

    }
}
