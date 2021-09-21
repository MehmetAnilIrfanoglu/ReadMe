using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadMe.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ReadMe_BusinessLayer.Test test = new ReadMe_BusinessLayer.Test();
            return View();
        }
    }
}