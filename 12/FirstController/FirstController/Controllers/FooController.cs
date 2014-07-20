using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class FooController : Controller
    {
        // GET: Foo
        public string Index()
        {
            return "this is the index method on foo";
        }
    }
}