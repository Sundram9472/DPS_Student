using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DPS_School.Areas.Principal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Principal/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}