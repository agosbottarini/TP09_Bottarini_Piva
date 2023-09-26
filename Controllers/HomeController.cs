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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult AgregarUsuario(string Username, string Contraseña, int Telefono, string Gmail, int Edad)
    {
        BD.AgregarUsuario(Username, Contraseña, Telefono, Gmail, Edad)

        return View("Index");
    }

    public IActionResult CambiarContraseña(string Contraseña,string Username)
    {
        BD.CambiarContraseña(Contraseña, UserName);
        return View("Index");
    }

    public IActionResult VerificarUsuario(string Contraseña, string Username)
    {
        if(BD.ObtenerUsuario(UserName, Contraseña) == NULL)
        {
            ViewBag.Error = "Usuario o Contraseña Incorrecta";
            return View("Index");
        }
        return View("Bienvenida")
    }
    
}
