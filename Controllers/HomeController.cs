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

    public IActionResult AgregarUsuario(string Username, string Contraseña, int Telefono, string Gmail, DateTime Edad)
    {
        if(BD.ObtenerUsuario(Username, Contraseña) == null)
        {
            BD.AgregarUsuario(Username, Contraseña, Telefono, Gmail, Edad);
            return View("Index");
        }
        else
        {
            ViewBag.NoEncontrado = "Ese Usuario ya existe";
            return View("Registro");
        }
        
        
    }

    public IActionResult ObtenerContraseña(int Telefono)
    {
        if(BD.ObtenerContraseña(Telefono) == null)
        {
            ViewBag.Contraseña = "Telefono incorrecto";
        }
        else
        {
            
            ViewBag.Contraseña = "Su contraseña es " + BD.ObtenerContraseña(Telefono);
        }
        
        return View("Olvide");
    }

    public IActionResult VerificarUsuario(string Contraseña, string UserName)
    {
        if(BD.ObtenerUsuario(UserName, Contraseña) == null)
        {
            ViewBag.Error = "Usuario o Contraseña Incorrecta";
            return View("Index");
        }
        ViewBag.Usuario = BD.ObtenerUsuario(UserName, Contraseña);
        return View("Bienvenida");
    }
    
}
