using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskNPoints.Repository.Contract;
using TaskNPoints.WebApp.Models;

namespace TaskNPoints.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository Repository;

        public HomeController(ILogger<HomeController> logger , StudentRepository studentRepository )
        {
            _logger = logger;
            Repository = studentRepository;
        }

        public IActionResult Index(string login, string password)
        {
            if (Repository.LogInUser(login, password))
            {
                return View();
            }
            else
            {
              return Redirect("/Login");
            }
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
