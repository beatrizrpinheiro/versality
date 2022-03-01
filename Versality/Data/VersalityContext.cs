using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Versality.Models;

namespace Versality.Data
{
    public class VersalityContext : DbContext
    {
        public VersalityContext (DbContextOptions<VersalityContext> options)
            : base(options)
        {
        }

        public DbSet<Versality.Models.ActiveMethods> ActiveMethods { get; set; }
    }
}
