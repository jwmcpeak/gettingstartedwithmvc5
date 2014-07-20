using FirstController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    [RoutePrefix("contact")]
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactMessage message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            // send the email

            return RedirectToAction("index", "home");
        }
    }
}