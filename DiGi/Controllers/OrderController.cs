using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Be;
using BlL;
using System.Windows;
namespace DiGi.Controllers
{
    public class OrderController : Controller
    {
        productsBll blp = new productsBll();
        usersBll blu = new usersBll();

        public async Task<IActionResult> AddToBasket(int prodid)
        {
            var basketlist = new List<int>();

            if (HttpContext.Session.GetString("basket") != null)
            {

                basketlist = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket")).ToList();
            }

            basketlist.Add(prodid);
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketlist));

            Products.Product catprod = blp.ReadById(prodid);

            return RedirectToAction("ReadByCategory", "Products", new { h = catprod.titleCategory });
        }
        public IActionResult Payment()
        {
            if (User.Identity.IsAuthenticated)
            {

                Random random = new Random();
                BlL.productsBll blp = new BlL.productsBll();


                List<int> codeFactors = blp.ReadFactorCodes();

                int NewCodeFactor = random.Next(100000000, 1000000000);

                bool checkCode = codeFactors.Any(k => k == NewCodeFactor);

                if (checkCode == false)
                {

                    return RedirectToAction("PaymentFactor", "Order", new { code = NewCodeFactor });
                }
                else
                {
                    NewCodeFactor = random.Next(100000000, 1000000000);
                    checkCode = codeFactors.Any(k => k == NewCodeFactor);

                    if (checkCode == false)
                    {
                        return RedirectToAction("PaymentFactor", "Order", new { code = NewCodeFactor });

                    }
                    else
                    {
                        NewCodeFactor = random.Next(100000000, 1000000000);
                        checkCode = codeFactors.Any(k => k == NewCodeFactor);

                        if (checkCode == false)
                        {
                            return RedirectToAction("PaymentFactor", "Order", new { code = NewCodeFactor });

                        }
                        return RedirectToAction("PaymentFactor", "Order", new { code = NewCodeFactor + "Duplickcode" });
                    }

                }
            }
            return RedirectToAction("Index", "Home");




        }
        public IActionResult PaymentFactor(int code)
        {
            if (User.Identity.IsAuthenticated)
            {
                Models.UserModel h = new Models.UserModel();
                h.code = code;

                return View(h);

            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowUserFactor(int codefactor)
        {
            if (User.Identity.IsAuthenticated)
            {
                Products.Factor factor = blp.ReadByCodeFactorInFactor(codefactor);
                List<Products.prodFactor> prod = blp.ReadByCodeFactorInProdFactor(codefactor);
                Users.Beusers user = blu.ReadById(factor.userid);

                ViewBag.PF = prod;
                ViewBag.Factor = factor;
                ViewBag.User = user;
                return View();

            }
            return RedirectToAction("Index", "Home");

        }
        public IActionResult RemoveInBasket(int prodid, string url)
        {

            var basketlist = new List<int>();

            if (HttpContext.Session.GetString("basket") != null)
            {

                basketlist = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket")).ToList();
            }

            basketlist.Remove(prodid);

            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketlist));

            return RedirectToAction("ShowFactor", "Account");


        }

        public IActionResult RemoveInBasketP()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
