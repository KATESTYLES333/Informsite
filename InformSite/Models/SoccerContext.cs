using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformSite.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
