using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core2WebApp.Models;
using Microsoft.Extensions.Logging;

namespace Core2WebApp.Controllers {
    public class HomeController : Controller {
        ILogger _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }
        public IActionResult Index() {
            _logger.LogInformation("Index action!");
            return View();
        }

        public IActionResult About() {
            _logger.LogInformation("About action!");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            _logger.LogInformation("Contact action!");
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            _logger.LogInformation("Privacy action!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            _logger.LogError("Error action!");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
