using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AL_IRSHAAD_MAGAMENT_SYSTEM.Models;
using AL_IRSHAD_SCHOOL_BOYSS.Models;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Term> Term { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Staff> Staff { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Class> Class { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Student__Reggs> Student__Reggs { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Student_Transfer> Student_Transfer { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Teacher> Teacher { get; set; }
        public DbSet<AL_IRSHAD_SCHOOL_BOYSS.Models.AccademicYearr> AccademicYearr { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.Exam> Exam { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.FEE> FEE { get; set; }
        public DbSet<AL_IRSHAAD_MAGAMENT_SYSTEM.Models.ApplicationUser> ApplicationUser { get; set; }
    }
}
