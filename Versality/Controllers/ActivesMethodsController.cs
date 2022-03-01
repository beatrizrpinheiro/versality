using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models;

namespace Versality.Controllers
{
    public class ActivesMethodsController : Controller
    {
        public IActionResult Index()
        {
            List<ActiveMethods> list = new List<ActiveMethods>();
            list.Add(new ActiveMethods { Id = 1, Name = "Problem Based Learning", Description = "The problem based learning is a method has the purpose to developing a learning process, based problems resolutation that manifest in various contexts" });
            list.Add(new ActiveMethods { Id = 2, Name = "Jigsaw", Description = "The Jigsaw is the method based on groups of employees, in which each one elects an expert employee, who will be in charge of teaching the other a specific function that will be taught by the chef in front of rounds" });
            list.Add(new ActiveMethods { Id = 3, Name = "Peer-Instruction", Description = "The Peer-Instruction is the method that uses all the capacity of the work environment to explore complex practices, through communication between employees and the questions that may arise both individually and collectively" });

            return View(list);
        }
    }
}
