using Microsoft.AspNetCore.Mvc;
using MvcAssignment4.Models;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;


namespace MvcAssignment4.Controllers
{
    namespace MvcAssignment4.Controllers
    {
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;

            private static List<Entry> blogEntries = new List<Entry>()
        {
            new Entry()
            {
                Id = 1,
                Category = "Coding",
                Title = "Asp.net core",
                Content = "Asp.net Core is the most popular web framwork, it is open-source"
            },

            new Entry()
            {
                Id = 2,
                Category = "Design",
                Title = "Strapping boots with Bootstrap",
                Content = "Quickly design and customize responsive mobile-first approach sites"
            }
        };

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

            public IActionResult Index()
            {
                
                return View(blogEntries);
            }

            public IActionResult Privacy()
            {
                return View();
            }

            public IActionResult BlogArticls()
            {
                return View(blogEntries);
            }

            public IActionResult BlogArticlesPartial()
            {
                return PartialView("_BlogArticles", blogEntries);
            }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

           

        }
    }
}