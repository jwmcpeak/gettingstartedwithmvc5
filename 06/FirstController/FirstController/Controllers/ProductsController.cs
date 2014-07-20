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
        public string Index(string category, int id)
        {
            if (!string.IsNullOrEmpty(category))
            {
                if (id > 0)
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

        public string Cpu(string id)
        {
            return "this is the cpu method: " + id;
        }
    }
}