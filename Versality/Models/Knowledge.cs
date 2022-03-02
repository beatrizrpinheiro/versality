using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models.ViewModels;

namespace Versality.Models
{
    public class Knowledge
    {
        public int Id { get; set; }
        public string ActionLeader { get; set; }

        public TheProblem TheProblem { get; set; }
        public int TheProblemId { get; set; }
       
        public Sector Sector { get; set; }
        public int SectorId { get; set; }
       


    }
}

     

