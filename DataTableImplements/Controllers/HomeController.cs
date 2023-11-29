using DataTableImplements.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DataTableImplements.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
           Colaboradores colaboradores = new Colaboradores();
            
            var listColaboradores = colaboradores.GetAll();
            return View(listColaboradores);
        }

        public async Task<IActionResult>  Privacy()
        {
            Colaboradores colaboradores = new Colaboradores();

            var listColaboradores =  colaboradores.GetAll();
            return View(listColaboradores);
        }

        public async Task<IActionResult> GetAll()
        {
            Colaboradores colaboradores = new Colaboradores();
            var listColaboradores =  colaboradores.GetAll();

            return  new JsonResult(listColaboradores);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}