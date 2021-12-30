using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Images.Controllers
{
    public class ArtController : Controller
    {
        // GET: Art
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult art()
        {
            return View();
        }
    }
}