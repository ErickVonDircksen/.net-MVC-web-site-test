using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace ControleDeContatos.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Criar()
    {
        return View();
    }
    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult Apagar()
    {
        return View();
    }
}   
