using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_RestaurantAssignment.Controllers
{
    public class MenuController : Controller
    {
        // GET: /Menu/Index
        public string Index()
        {
            return "Hello from Menu.Index()";
        }
        //
        // GET: /Menu/Browse?category=Appetizers
        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode("Menu.Browse, Category = "
        + category);

            return message;
        }
        //
        // GET: /Menu/Details/5
        public string Details(int id)
        {
            string message = "Menu.Details, ID = " + id;

            return message;
        }
    }
    
}