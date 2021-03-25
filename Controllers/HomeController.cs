using Assignment3Final.Models;
using Assignment3Final.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDBContext _context;
        private IMovieRepository _repository;

        public HomeController(ILogger<HomeController> logger, MovieDBContext context, IMovieRepository repository)
        {
            _context = context;
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie appResponse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appResponse);
                _context.SaveChanges();
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult MovieList()
        {
            return View(new MovieListViewModel
            {
                Movies = _repository.Movies
                .Where(m => m.Title != "Independence Day")
            });
        }



        [HttpGet]
        public IActionResult Edit(Movie appresponse)
        {
            return View(appresponse);
        }




        [HttpPost]
        public IActionResult EditSubmit(Movie appresponse)
        {
            _context.Movies.Update(appresponse);
            _context.SaveChanges();
            return View("MovieList", new MovieListViewModel
            {
                Movies = _repository.Movies
                .Where(m => m.Title != "Independence Day")
            });
        }

        public IActionResult Delete(Movie appresponse)
        {
            _context.Movies.Remove(appresponse);
            _context.SaveChanges();
            return View("Confirmation");
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
