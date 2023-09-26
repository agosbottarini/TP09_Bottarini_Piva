using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09_Bottarini_Piva.Models;

namespace TP09_Bottarini_Piva.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
        public IActionResult Olvide()
    {
        return View();
    }

       public IActionResult Bienvenida()
    {
        return View();
    }

       public IActionResult Registro()
    {
        return View();
    }       
    
    public IActionResult Terminos()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
