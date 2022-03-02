using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Data;
using Versality.Models;

namespace Versality.Services
{
    public class SectorService
    {
        private readonly VersalityContext _context;
        public SectorService(VersalityContext context)
        {
            _context = context;
        }

        public List<Sector> FindAll()
        {
            return _context.Sector.OrderBy(X => X.Name).ToList();
        }
        public void Insert(Knowledge obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

