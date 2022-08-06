using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Be;
using Microsoft.AspNetCore.Hosting;

namespace DiGi.Controllers
{
    public class ProductsController : Controller
    {


        private readonly IWebHostEnvironment Environment;



        public ProductsController(IWebHostEnvironment _environment)
        {

            Environment = _environment;
        }
        BlL.productsBll bl = new BlL.productsBll();





        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create(Models.ProductsModel h)
        {
            Upload up = new Upload(Environment);

            var newProduct = new Products.Product
            {
                nameProduct = h.nameProduct,

                price = h.price,

                pics = up.Uploadfile(h.pics),

                description = h.description,

                camra = h.camra,

                dimensions = h.dimensions,

                batterySpecifications = h.batterySpecifications,

                bodyStructure = h.bodyStructure,

                introductionTime = h.introductionTime,

                memoryCard = h.memoryCard,

                numberProducts = h.numberProducts,

                operatingSystem = h.operatingSystem,

                productModel = h.productModel,

                screen = h.screen,

                screenSize = h.screenSize,

                specialFeatures = h.specialFeatures,

                weight = h.weight

            };
            bl.Create(newProduct);
            return RedirectToAction("productsPanel", "Admin");
        }
        public IActionResult Search(string h)
        {

            ViewBag.Products = bl.Search(h);

            return View("Views/Admin/productsPanel.cshtml");

        }
        public IActionResult Delete(int id)
        {
            bl.Delete(id);

            return RedirectToAction("productsPanel", "Admin");
        }
        public IActionResult Edit(Models.ProductsModel h)
        {
            var editProd = bl.ReadById(h.id);

            if (editProd != null)
            {
                Upload up = new Upload(Environment);
                var newProd = new Products.Product
                {
                    Id=h.id,
                    nameProduct = h.nameProduct,
                    price = h.price,
                    description = h.description,
                    camra = h.camra,
                    dimensions = h.dimensions,
                    weight = h.weight,
                    screen = h.screen,
                    screenSize = h.screenSize,
                    bodyStructure = h.bodyStructure,
                    specialFeatures = h.specialFeatures,
                    introductionTime = h.introductionTime,
                    productModel = h.productModel,
                    memoryCard = h.memoryCard,
                    numberProducts = h.numberProducts,
                    batterySpecifications = h.batterySpecifications,
                    pics = up.Uploadfile(h.pics),
                    operatingSystem = h.operatingSystem
                };

                bl.EditProducts(newProd);

                return RedirectToAction("productsPanel", "Admin");
                  
            }else return RedirectToAction("productsPanel", "Admin");
        }
        public IActionResult ReadByCategory(string h)
        {
            ViewBag.Products = bl.ReadByCategory(h);

            return View();
        }

    }

}
