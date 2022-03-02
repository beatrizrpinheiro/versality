using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versality.Models;
using Versality.Report;

namespace Versality.Controllers
{
    public class PeerInstructionsController : Controller
    {
        public ActionResult Report()
        {
            PeerInstructionReport peerInstructionReport = new PeerInstructionReport();
            byte[] abytes = peerInstructionReport.PrepareReport(GetPeerInstructions());
            return File(abytes, "application/pdf");
        }

        public List<PeerInstruction> GetPeerInstructions()
        {
            List<PeerInstruction> peerInstructions = new List<PeerInstruction>();
            PeerInstruction peerInstruction = new PeerInstruction();

            for (int i = 1; i <= 1; i++)
            {
                peerInstruction = new PeerInstruction();
                peerInstruction.Id = i;
                peerInstruction.Name = "Peer Instruction Method";
                peerInstruction.Solution = "Step one: to explain the centers elements of problem and your solutions."+
                    "-------Step two: to explain a multiple choice question, so that employee respond according to the knowledge learned in step one" +
                    "-------Step Three: the employees should reflect for 5 minutes one the question presented, and after to speak a solution for their" +
                    "-------Step four: The action leader should to explain the correct answer to the question";
                peerInstructions.Add(peerInstruction);
            }
            return peerInstructions;
        }
    }
}
