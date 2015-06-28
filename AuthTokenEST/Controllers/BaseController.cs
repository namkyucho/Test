using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace AuthTokenEST.Controllers
{
    public class BaseController : Controller
    {
        public class CheckTokenFilter : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.Controller.ViewBag.TestMsg = "Custom Action Filter: Message from OnActionExecuting Method";
                var D1 = filterContext.HttpContext.Request.QueryString["d1"];
                if (D1 != null)
                { 
                    filterContext.Controller.ViewBag.Request_1 = D1; 
                }
            }
        }
        
    }
}
