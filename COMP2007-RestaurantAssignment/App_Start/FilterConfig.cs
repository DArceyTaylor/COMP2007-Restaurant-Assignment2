﻿using System.Web;
using System.Web.Mvc;

namespace COMP2007_RestaurantAssignment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
