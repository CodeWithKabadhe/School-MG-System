using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Models
{
    public class RoleViewModel
    {
        [Key]
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}
