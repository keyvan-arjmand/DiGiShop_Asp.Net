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
            var daluser = bl.SearchUserName(h.Username);



            if (user == null)
            {
                ModelState.AddModelError("", "کاربر با این نام کاربری وجود ندارد");
                return View(h);
            }

            if (daluser.admin == 1)
            {

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
    }
}
