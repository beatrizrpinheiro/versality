using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versality.Models.ViewModels
{
    public class KnowledgeFormViewModel
    {
        public Knowledge Knowledge { get; set; }
        public ICollection<TheProblem> Problems { get; set; }
        public List<TheProblem> TheProblem { get; internal set; }
        public ICollection<Sector> Sectors { get; set; }
        public List<Sector> TheSectors { get; internal set; }
    }
}
