using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Be.Users;

namespace DiGi.Controllers
{

    public class AdminController : Controller
    {

        private readonly IWebHostEnvironment Environment;

        private UserManager<UserApp> userManager;

        private SignInManager<UserApp> signInManager;
        public AdminController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager, IWebHostEnvironment _environment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            Environment = _environment;
        }
        BlL.usersBll bl = new BlL.usersBll();


        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                var user = bl.SearchUserName(User.Identity.Name);

                if (user.admin == 1)
                {

                    RedirectToAction("Index", "Home");
                } else if (user.admin == 0)
                {
                    return View("dashAdmin");
                }

            }
            return RedirectToAction("Index", "Home");



        }
        public IActionResult panelAdmin()
        {

            if (User.Identity.IsAuthenticated)
            {

                var user = bl.SearchUserName(User.Identity.Name);

                if (user.admin == 1)
                {

                    RedirectToAction("Index", "Home");
                }
                else if (user.admin == 0)
                {
                    ViewBag.users = bl.getskip(0);
                    return View("panelAdmin");
                }

            }
            return RedirectToAction("Index", "Home");

        

        }

        public IActionResult productsPanel()
        {

            if (User.Identity.IsAuthenticated)
            {

                var user = bl.SearchUserName(User.Identity.Name);

                if (user.admin == 1)
                {

                    RedirectToAction("Index", "Home");
                }
                else if (user.admin == 0)
                {
                    return View();
                }

            }
            return RedirectToAction("Index", "Home");



        }
    }
}
