using Roller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roller.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "The Avengers"},
                new Movie {Name = "Titanic"}
            };

            return View(movies);

        }

        public ActionResult Details()
        {
            
            return View();


            
        }
    }
}