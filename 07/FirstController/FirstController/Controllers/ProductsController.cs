﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        
        public string Index()
        {
            return "this is all products";
        }

        [Route("{category}")]
        public string ShowCategory(string category)
        {

            return "this is the products in the " + category + " category";

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