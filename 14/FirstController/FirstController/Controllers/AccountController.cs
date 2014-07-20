using FirstController.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            // password for jwmcpeak is asdlfkf@RAG04
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = await userManager.FindAsync(model.Username, model.Password);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "The user with the supplied credentials does not exist.");
                return View(model);
            }

            var authManager = HttpContext.GetOwinContext().Authentication;
            var userIdentity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

            authManager.SignIn(new AuthenticationProperties { IsPersistent = model.RememberMe }, userIdentity);

            return RedirectToAction("index", "home");
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;


            authManager.SignOut();

            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var user = await userManager.FindAsync(model.Username, model.Password);

            if (user != null)
            {
                ModelState.AddModelError(string.Empty, "The user already exists.");
                return View(model);
            }

            user = new IdentityUser { UserName = model.Username, Email = model.Email };

            await userManager.CreateAsync(user, model.Password);

            return RedirectToAction("index", "home");
        }

        [NonAction]
        public async Task<ActionResult> CreateRole(string roleName)
        {
            var roleStore = new RoleStore<IdentityRole>();
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var role = await roleManager.FindByNameAsync(roleName);

            if (role != null)
            {
                return View();
            }

            role = new IdentityRole { Name = roleName };

            await roleManager.CreateAsync(role);

            return RedirectToAction("index", "home");
        }

        [NonAction]
        [Authorize]
        public async Task<ActionResult> AddUserToRole(string roleName)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var roleStore = new RoleStore<IdentityRole>();
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var role = await roleManager.FindByNameAsync(roleName);

            if (role == null)
            {
                return View();
            }


            await userManager.AddToRoleAsync(User.Identity.GetUserId(), roleName);
   
            return RedirectToAction("index", "home");
        }
    }
}