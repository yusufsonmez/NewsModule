using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsModule.Models;

namespace NewsModule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsContext _context;

        public HomeController(ILogger<HomeController> logger, NewsContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Index()
        {
            // Son 4 haberi ceker
            var list = _context.News.Take(4).Where(n => n.IsPublish).OrderByDescending(x => x.CreateTime).ToList();
            foreach (var news in list)
            {
                news.Author = _context.Author.Find(news.AuthorId);
            }
            return View(list);
        }

        public IActionResult Post(int Id)
        {
            // id bilgisiyle postu alıp Post.cshtml'de goruntuler.
            var news = _context.News.Find(Id);
            news.Author = _context.Author.Find(news.AuthorId);
            news.ImagePath = "/img/" + news.ImagePath;
            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
