using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers;

public class HomeController : Controller
{
   

    public IActionResult index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
