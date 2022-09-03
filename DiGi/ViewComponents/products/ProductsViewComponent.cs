using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Be;
namespace DiGi.ViewComponents.products
{
    public class ProductsViewComponent :ViewComponent
    {

        public IViewComponentResult Invoke(string Catgory=null)
        {
            Models.ProductsModel h = new Models.ProductsModel();
            h.Catgory = Catgory;
            return View("_products",h);
        }
    }
}
