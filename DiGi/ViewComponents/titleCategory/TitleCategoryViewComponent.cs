using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.ViewComponents.titleCategory
{
    public class TitleCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string Catgory = null)
        {
            Models.ProductsModel h = new Models.ProductsModel();
            h.Catgory = Catgory;
            return View("_titleCategory", h);
        }
    }
}
