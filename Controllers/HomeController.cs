using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using technicalAssesment.Models;
using technicalAssesment.Models.Domain;
using Microsoft.EntityFrameworkCore.Query.Internal;
using technicalAssesment.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using technicalAssesment.Controllers;


namespace technicalAssesment.Controllers
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
            //return View("Index", "CustomerController");

            return RedirectToAction("Index", "Customer");
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
}