using FirstController.Data;
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
            var repo = new ProductRepository();

            return View(repo.All());
        }

        [Route("{category}")]
        public ActionResult ShowCategory(string category)
        {
            var repo = new ProductRepository();

            return View(repo.GetByCategory(category));

        }

        [Route("{category}/{id:int}")]
        public ActionResult Details(string category, int id, string format = null)
        {
            var repo = new ProductRepository();
            var product = repo.Find(p => p.Id == id);

            if (product.Categories.Any(c => c.Name == category))
            {
                if (format == "json")
                {
                    return Json(product, JsonRequestBehavior.AllowGet);
                }

                return View(product);
            }

            return HttpNotFound();
        }

        [Route("~/for-sale/{category?}")]
        public string Sale(string category)
        {
            return "these are the items for sale " + category;
        }
    }
}