﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Admin.Controllers.Attributes
{
    public class NoDirectAccessAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.UrlReferrer == null ||
                        filterContext.HttpContext.Request.Url.Host != filterContext.HttpContext.Request.UrlReferrer.Host)
            {

                //Mandar 404? ou para ErrorViewModel
                filterContext.Result = new RedirectToRouteResult(new
                               RouteValueDictionary(new { controller = "Home", action = "Index", area = "" }));
            }
        }
    }
}