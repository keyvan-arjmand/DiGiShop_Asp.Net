using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> AddToBasket(int prodid)
        {
            var basketlist = new List<int>();

            if (HttpContext.Session.GetString("basket") != null)
            {
                basketlist = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket")).ToList();
            }

            basketlist.Add(prodid);
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketlist));


            return RedirectToAction("Index", "Home", new { id = prodid });
        }
    }
}
