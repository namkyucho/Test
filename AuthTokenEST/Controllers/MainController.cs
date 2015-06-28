using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthTokenEST.Controllers
{
    public class MainController : BaseController
    {
        //
        // GET: /Main/
        [CheckTokenFilter]
        public ActionResult Index(decimal d1, decimal d2)
        {
            return View();
        }

    }
}
