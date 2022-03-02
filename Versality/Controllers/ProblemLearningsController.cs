using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models;
using Versality.Report;

namespace Versality.Controllers
{
    public class ProblemLearningsController : Controller
    {
        public ActionResult Report()
        {
            ProblemLearningReport problemLearningReport = new ProblemLearningReport();
            byte[] abytes = problemLearningReport.PrepareReport(GetProblemLearnings());
            return File(abytes, "application/pdf");
        }

        public List<ProblemLearning> GetProblemLearnings()
        {
            List<ProblemLearning> problemLearnings = new List<ProblemLearning>();
            ProblemLearning problemLearning = new ProblemLearning();

            for (int i = 1; i <= 1; i++)
            {
                problemLearning = new ProblemLearning();
                problemLearning.Id = i;
                problemLearning.Name = "Problem Based Learning Method";
                problemLearning.Solution = "Step one: to explain a problem to the employees." +
                    "-------Step two: studying the problem" +
                    "-------Step Three: the employees must to suggest a solution for the problem with previous knowledge" +
                    "-------Step four: the employees must planning the action plan with solution objectives, defining who, how and where to look the concret solution" +
                    "-------Step five: to use the news knowledges for trying to solution the initial problem" +
                    "-------Step six: The Action Leader must assess wheather the solution used is appropriate";
                problemLearnings.Add(problemLearning);
            }
            return problemLearnings;
        }

    }
}
