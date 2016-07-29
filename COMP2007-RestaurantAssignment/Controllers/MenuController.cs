using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_RestaurantAssignment.Models;

namespace COMP2007_RestaurantAssignment.Controllers
{
    public class MenuController : Controller
    {
        // GET: /Menu/Index
        public ActionResult Index()
        {
            var menuCategories = new List<Categories>
    {
        new Categories { FoodCategory = "Appetizers"},
        new Categories { FoodCategory = "Entres"},
        new Categories { FoodCategory = "Dessert"},
        new Categories { FoodCategory = "Drinks"}
    };
            return View(menuCategories);
        }
        //
        // GET: /Menu/Browse?category=Appetizers
        public ActionResult Browse(string category)
        {
            var categoryModel = new Categories { FoodCategory = category };
            return View(categoryModel);
        }
        //
        // GET: /Menu/Details/5
        public ActionResult Details(int id)
        {
            var category = new Categories { FoodCategory = "Category " + id };
            return View(category);
        }
    }
    
}