﻿using System.Web;
using System.Web.Mvc;

namespace JS20190317TP4ArraysAndFunctions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
