using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoModels;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.Models;

namespace MySqlDemo.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();
        public IActionResult Index()
        {
            Employee emp = new Employee
            {
                Id=1,
                Name="Shareef U Din Bhat"
            };
            db.Add(emp);
            db.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
