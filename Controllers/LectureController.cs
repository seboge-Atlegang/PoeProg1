using Microsoft.AspNetCore.Mvc;
using ProgPoe.Models;
using System.Collections.Generic;

namespace ProgPoe.Controllers
{
    public class LecturerController : Controller
    {
        // temporary in-memory store
        public static List<MonthlyClaim> claims = new List<MonthlyClaim>();

        public IActionResult Index()
        {
            return View(claims); // view all claims submitted
        }

        [HttpPost]
        public IActionResult Submit(MonthlyClaim claim)
        {
            claim.ClaimId = claims.Count + 1;
            claim.Status = "Pending";
            claims.Add(claim);

            return RedirectToAction("Index");
        }
    }
}
