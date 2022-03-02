using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versality.Models.ViewModels
{
    public class TheProblem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sector { get; set; }
        public DateTime DateProblem { get; set; }

    }
}
