using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versality.Models.ViewModels
{
    public class Forum
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
