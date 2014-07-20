using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [Route("{category}")]
        public ActionResult ShowCategory(string category)
        {

            return View();

        }

        [Route("{category}/{id:int}")]
        public string Details(string category, int id)
        {

            return "this is an individual " + category +
                " product with an id of " + id;
        }

        [Route("~/for-sale/{category?}")]
        public string Sale(string category)
        {
            return "these are the items for sale " + category;
        }
    }
}