using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Vidly_Mosh_KZK.Models;
using Vidly_Mosh_KZK.ViewModels;

namespace Vidly_Mosh_KZK.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Kazuki!" };
            var customers = new List<Customer>() 
            {
                new Customer() { Name = "Customer 1"},
                new Customer() { Name = "Customer 2"},
                new Customer() { Name = "Customer 3"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]

        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        ////movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex = {0} & sortBy= {1}", pageIndex, sortBy));
        //}

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}