using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "<b>This is the value of id: </b>" + id;
        }

        [NonAction]
        public string Foo()
        {
            return "this is the foo method.";
        }
    }
}