using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgPoe.Data;
using ProgPoe.Models;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string role)
    {
        if (role == "lecturer")
            return RedirectToAction("Index", "Lecturer");
        if (role == "admin")
            return RedirectToAction("Index", "Admin");

        return View();
    }

    public IActionResult Logout()
    {
        return RedirectToAction("Login");
    }
}


