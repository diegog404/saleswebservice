using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using saleswebmvc.Models;
using saleswebmvc.Models.ViewModels;

namespace saleswebmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Sobre"] = "Aluno Diego Gomes Nogueira da Silva";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
