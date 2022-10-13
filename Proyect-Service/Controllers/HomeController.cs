using Microsoft.AspNetCore.Mvc;
using Proyect_Service.Models;
using Proyect_Service.Models.ViewModels;
using System.Diagnostics;

namespace Proyect_Service.Controllers
{
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

        /*[HttpGet]
        public IActionResult EmpresaDetalle()
        {
            UsuarioVM oUsuario = new UsuarioVM();  
            oUsuario = new UsuarioVM(),
            oListaEmpresa = _DBContext.Cargos.Select
            return View();
        }*/
    }
}