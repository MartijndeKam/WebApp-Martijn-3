﻿using System.Web;
using System.Web.Mvc;

namespace WebApp_Martijn_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
