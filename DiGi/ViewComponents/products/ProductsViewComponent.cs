using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.ViewComponents.products
{
    public class ProductsViewComponent :ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("_products");
        }
    }
}
