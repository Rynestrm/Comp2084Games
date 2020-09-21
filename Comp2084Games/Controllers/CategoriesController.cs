using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp2084Games.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comp2084Games.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            // use our category model and some fake data to pass to the view
            // make an empty list of categories
            var categories = new List<Category>();

            // use a loop to make 10 categories and add each one to the list
            for(var i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category " + i.ToString() });
            }

            // now pass category list when loading the view

            return View(categories);
        }

        public IActionResult Browse(string categoryName)
        {
            // take category name passed in with the link and store it in the viewbag for display
            ViewBag.categoryName = categoryName;

            // load Views Category Browse
            return View();
        }
    }
}
