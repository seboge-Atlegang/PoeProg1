using Microsoft.AspNetCore.Mvc;
using ProgPoe.Models;
using System.Collections.Generic;

namespace ProgPoe.Controllers
{
    public class AdminController : Controller
    {
        // temporary in-memory store (replace with DbContext later)
        public static List<MonthlyClaim> claims = new List<MonthlyClaim>();

        public IActionResult Index()
        {
            return View(claims); // send claims to view
        }

        public IActionResult Approve(int id)
        {
            var claim = claims.Find(c => c.ClaimId == id);
            if (claim != null)
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Reject(int id)
        {
            var claim = claims.Find(c => c.ClaimId == id);
            if (claim != null)
            {
                claim.Status = "Rejected";
            }
            return RedirectToAction("Index");
        }
    }
}
