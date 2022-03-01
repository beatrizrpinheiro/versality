using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Versality.Models;
using Versality.Models.ViewModels;

namespace Versality.Data
{
    public class VersalityContext : DbContext
    {
        public VersalityContext (DbContextOptions<VersalityContext> options)
            : base(options)
        {
        }

        public DbSet<Versality.Models.ActiveMethods> ActiveMethods { get; set; }

        public DbSet<Versality.Models.ViewModels.TheProblem> TheProblem { get; set; }

        public DbSet<Versality.Models.Knowledge> Knowledge { get; set; }
    }
}
