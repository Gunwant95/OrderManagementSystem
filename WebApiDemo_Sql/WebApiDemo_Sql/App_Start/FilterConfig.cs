﻿using System.Web;
using System.Web.Mvc;

namespace WebApiDemo_Sql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
