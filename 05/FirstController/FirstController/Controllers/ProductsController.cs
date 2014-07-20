using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index(string category, string id)
        {
            if (!string.IsNullOrEmpty(category))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    return "this is an individual" + category + 
                        " product with an id of " + id;
                }
                else
                {
                    return "this is the products in the " + category;
                }
            }

            return "this is all products";


        }
    }
}