using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models;
using Versality.Report;

namespace Versality.Controllers
{
    public class JigsawsController : Controller
    {
        public ActionResult Report()
        {
            JigsawReport jigsawReport = new JigsawReport();
            byte[] abytes = jigsawReport.PrepareReport(GetJigsaws());
            return File(abytes, "application/pdf");
        }

        public List<Jigsaw> GetJigsaws()
        {
            List<Jigsaw> jigsaws = new List<Jigsaw>();
            Jigsaw jigsaw = new Jigsaw();

            for (int i = 1; i <= 1; i++)
            {
                jigsaw = new Jigsaw();
                jigsaw.Id = i;
                jigsaw.Name = "Jigsaw Method";
                jigsaw.Solution = "Step one: to form groups until 4 employees to read new or updated function" +
                    "-------Step two: to form groups of leaders and discuss, through the Action Leader the solution to a specific question about reading of step one" +
                    "-------Step Three: the leaders return to the base group to discuss and reach consensus on the solution given in step two.";
                jigsaws.Add(jigsaw);
            }
            return jigsaws;
        }
    }
}
