using Be;
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
        BlL.productsBll blp = new BlL.productsBll();


        public async Task<IActionResult> Index()
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
        public IActionResult ShowUsers()
        {
            if (User.Identity.IsAuthenticated)
            {

                var listuser = new List<Models.UserModel>();

                var users = bl.Read();

                foreach (var i in users)
                {
                    listuser.Add(new Models.UserModel
                    {
                        id = i.Id,
                        Username = i.username,
                        FirstName = i.name,
                        LastName = i.family,
                        Email = i.email,
                        admin = i.admin,
                        phoneNumber = i.phoneNumber,
                        pic2 = i.pic
                    });

                }

                return View(listuser);
            }
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Searchuser(string info)
        {
            var searchuser = bl.SearchUsers(info);

            var usermodel = new List<Models.UserModel>();
            foreach (var i in searchuser)
            {
                usermodel.Add(new Models.UserModel
                {
                    id = i.Id,
                    FirstName = i.name,
                    LastName = i.family,
                    admin = i.admin,
                    phoneNumber = i.phoneNumber,
                    Email = i.email,
                    pic2 = i.pic,
                    Username = i.username
                });

            }
            return View("ShowUsers", usermodel);

        }
        public IActionResult ShowFactors()
        {
            if (User.Identity.IsAuthenticated)
            {
                var Factorlist = blp.ReadFactor();
                ViewBag.Factors = Factorlist;

                return View();

            }
            return RedirectToAction("Index", "Home");



        }
        public IActionResult SearchFactor(string info)
        {
            var searchlist = blp.SearchFactor(info);
            ViewBag.Factors = searchlist;
            return View("ShowFactors");
        }

        public IActionResult ShowAdminFactor(int codefactor)
        {
            if (User.Identity.IsAuthenticated)
            {

                Products.Factor factor = blp.ReadByCodeFactorInFactor(codefactor);
                List<Products.prodFactor> prod = blp.ReadByCodeFactorInProdFactor(codefactor);
                Users.Beusers user = bl.ReadById(factor.userid);

                ViewBag.PF = prod;
                ViewBag.Factor = factor;
                ViewBag.User = user;
                return View();


            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ShowAdminProf()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.user = bl.SearchUserName(User.Identity.Name);

                return View("ShowAdminProfile");

            }
            return RedirectToAction("Index", "Home");

        }
    }
}
