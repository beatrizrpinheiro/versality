using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Data;
using Versality.Models.ViewModels;

namespace Versality.Services
{
    public class TheProblemService
    {
        private readonly VersalityContext _context;
        public TheProblemService(VersalityContext context)
        {
            _context = context;
        }

        public List<TheProblem> FindAll()
        {
            return _context.TheProblem.OrderBy(X => X.Name).ToList();
        }
        }
    }

