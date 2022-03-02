using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models;

namespace Versality.Controllers
{
    public class SectorsController : Controller
    {
        public IActionResult Index()
        {
            List<Sector> list = new List<Sector>();
            list.Add(new Sector { Id = 1, Name = "Operation Information Technology"});
            list.Add(new Sector { Id = 2, Name = "Call Center" });
            list.Add(new Sector { Id = 3, Name = "Customer Sucess" });

            return View(list);
        }
    }
}
