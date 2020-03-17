using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayouts.Controllers
{
    public class BindController : Controller
    {
        // GET: Bind
        [ActionName("Example")]
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}