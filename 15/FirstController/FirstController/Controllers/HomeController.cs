using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index(string id)
        {
            return View();
        }

        public ActionResult Foo()
        {
            return new HttpUnauthorizedResult();
        }

        public ActionResult Document(string id)
        {
            return File(@"C:\Users\Jeremy McPeak\Documents\Hello ActionResult.pdf", "application/pdf", "test.pdf");
        }
    }
}