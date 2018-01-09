using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registrations.Models
{
    public class RegistrationsDbContext:DbContext
    {
        public DbSet<DayAtDaddyWork> DayAtDaddyWorks { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public RegistrationsDbContext() : base("name=DefaultConnection")
        {

        }
        public static RegistrationsDbContext Create()
        {
            return new RegistrationsDbContext();
        }
    }
}