using BlL;
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
    public class AccountController : Controller
    {



        private readonly IWebHostEnvironment Environment;

        private UserManager<UserApp> userManager;

        private SignInManager<UserApp> signInManager;

        public AccountController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager, IWebHostEnvironment _environment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            Environment = _environment;
        }

        usersBll bl = new usersBll();
        productsBll blp = new productsBll();


        public async Task<IActionResult> signUp()
        {
            return View();

        }
        public async Task<IActionResult> login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(Models.UserModel h)
        {
            var user = await userManager.FindByNameAsync(h.Username);
            Beusers daluser = new Beusers();


            if (user == null)
            {
                ModelState.AddModelError("", "کاربر با این نام کاربری وجود ندارد");
                return View(h);
            }

            if (daluser.admin == 1)
            {
                daluser = bl.SearchUserName(h.Username);

                var signinresult = await signInManager.PasswordSignInAsync(user, h.Password, true, false);
                if (!signinresult.Succeeded)
                {
                    ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
                    return View(h);
                }


                return RedirectToAction("index", "Home");


            }
            else if (daluser.admin == 0)

            {
                daluser = bl.SearchUserName(h.Username);
                var signinresult = await signInManager.PasswordSignInAsync(user, h.Password, true, false);
                if (!signinresult.Succeeded)
                {
                    ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
                    return View(h);
                }



                return RedirectToAction("index", "Admin", daluser);

            }
            return RedirectToAction("index", "Home");

        }
        [HttpPost]
        public async Task<IActionResult> signUp(Models.UserModel h)
        {
            var user = await userManager.FindByNameAsync(h.Username);

            if (user != null)
            {
                ModelState.AddModelError("", "کاربر با این مشخصات وجود دارد");
                return View(h);
            }
            else
            {
                var idenUser = new UserApp
                {

                    UserName = h.Username,
                    Email = h.Email,
                    Firstname = h.FirstName,
                    Lastname = h.LastName,
                    PhoneNumber = h.phoneNumber

                };

                Upload up = new Upload(Environment);

                var Users = new Beusers
                {
                    name = h.FirstName,
                    family = h.LastName,
                    email = h.Email,
                    username = h.Username,
                    password = h.Password,
                    phoneNumber = h.phoneNumber,
                    pic = up.Uploadfile(h.pic),
                    admin = 1,



                };

                bl.create(Users);
                var adduser = await userManager.CreateAsync(idenUser, h.Password);

                return RedirectToAction("index", "Home");

            }




        }
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            else return RedirectToAction("Index", "Home");


        }
        public void gettotal()
        {

            bl.gettotal();
        }
        public IActionResult getskip(int c)
        {

            return View("PG", bl.getskip(c));
        }

        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult ShowFactor()
        {
            return View();
        }
        public IActionResult ShowProfile(string username)
        {
            if (User.Identity.IsAuthenticated)
            {

                var listuser = bl.SearchUserName(username);

                var user = new Models.UserModel
                {
                    admin = listuser.admin,
                    Email = listuser.email,
                    FirstName = listuser.name,
                    LastName = listuser.family,
                    id = listuser.Id,
                    Password = listuser.password,
                    phoneNumber = listuser.phoneNumber,
                    pic2 = listuser.pic,
                    Username = listuser.username
                };
                var factor = bl.UserFactors(listuser.Id);

                var factorlist = new List<Be.Products.Factor>();
                var prodfactor = new List<Be.Products.prodFactor>();

                foreach (var i in factor)
                {
                    factorlist.Add(new Be.Products.Factor
                    {
                        FactorCode = i.FactorCode,
                        address = i.address,
                        Id = i.Id,
                        timePurchase = i.timePurchase,
                        totalPrice = i.totalPrice,
                        userid = i.userid

                    });

                    List<Be.Products.prodFactor> pf = blp.ReadByCodeFactorInProdFactor(i.FactorCode);

                    foreach (var q in pf)
                    {
                        prodfactor.Add(new Be.Products.prodFactor
                        {
                            factorid = q.factorid,
                            FactorCode = q.FactorCode,
                            productsid = q.productsid
                        });

                    }

                }


                ViewBag.FactorList = factorlist;
                ViewBag.ProdFactor = prodfactor;

                return View(user);
            }
            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> LogoutAdmin(string h)
        {
            if (User.Identity.IsAuthenticated)
            {
                Beusers i = bl.SearchUserName(h);
                Models.UserModel user = new Models.UserModel
                {
                    Username = i.username,
                    FirstName = i.name,
                    LastName = i.family,
                    pic2 = i.pic,

                };

                await signInManager.SignOutAsync();

                return View("LockScreenAdmin", user);

            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult LoginAdmin()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> LoginAdmin(Beusers h)
        {

            var user = await userManager.FindByNameAsync(h.username);
            var daluser = bl.SearchUserName(h.username);



            if (user == null)
            {
                ModelState.AddModelError("", "کاربر با این نام کاربری وجود ندارد");
                return RedirectToAction("LoginAdmin", "Account");
            }

            if (daluser.admin == 0)
            {

                var signinresult = await signInManager.PasswordSignInAsync(user, h.password, true, false);

                if (!signinresult.Succeeded)
                {
                    ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
                    return RedirectToAction("LoginAdmin", "Account");
                }

                return RedirectToAction("Index", "Admin");
            }
            return RedirectToAction("Index", "Home");


        }
        [HttpPost]
        public IActionResult EditUser(Models.UserModel h)
        {
            Upload up = new Upload(Environment);
            var user = new Beusers
            {
                Id = h.id,
                name = h.FirstName,
                family = h.LastName,
                email = h.Email,
                password = h.Password,
                username = h.Username,
                pic = up.Uploadfile(h.pic),
                admin = h.admin,
                phoneNumber = h.phoneNumber
            };

            bl.EditUser(user);

            return RedirectToAction("panelAdmin", "Admin");

        }
        public IActionResult EditAdmin(Models.UserModel h)
        {
            Upload up = new Upload(Environment);
            var user = new Beusers
            {
                Id = h.id,
                name = h.FirstName,
                family = h.LastName,
                email = h.Email,
                password = h.Password,
                username = h.Username,
                pic = up.Uploadfile(h.pic),
                admin = h.admin,
                phoneNumber = h.phoneNumber
            };

            bl.EditUser(user);

            return RedirectToAction("ShowAdminProf", "Admin");

        }
    }
}
