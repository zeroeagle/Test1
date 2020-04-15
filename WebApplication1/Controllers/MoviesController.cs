﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek!" };
            return View(movie);
        }
        public ActionResult Edit(int movieid)
        {
            return Content("id=" + movieid);
        }

        public ActionResult Index()
        {
            return new EmptyResult();
        }

    }
}