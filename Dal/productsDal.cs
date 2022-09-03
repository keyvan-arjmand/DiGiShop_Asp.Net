using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Be;

namespace Dal
{

    public class productsDal
    {

        DB db = new DB();

        public void Create(Products.Product h)
        {
            db.products.Add(h);
            db.SaveChanges();

        }
        public List<Products.Product> Read()
        {
            return db.products.ToList();
        }
        public List<Products.Product> Search(string h)
        {
            var q = from i in db.products
                    where i.nameProduct.Contains(h) || i.productModel.Contains(h) || i.nameProduct.Contains(h) || i.operatingSystem.Contains(h)
                    select i;
            return q.ToList();


        }

        public void EditProducts(Products.Product newProd)
        {
            var q = from i in db.products
                    where i.Id == newProd.Id
                    select i;
            var prod = q.Single();

            prod.nameProduct = newProd.nameProduct;
            prod.price = newProd.price;
            prod.description = newProd.description;
            prod.camra = newProd.camra;
            prod.dimensions = newProd.dimensions;
            prod.weight = newProd.weight;
            prod.screen = newProd.screen;
            prod.screenSize = newProd.screenSize;
            prod.bodyStructure = newProd.bodyStructure;
            prod.specialFeatures = newProd.specialFeatures;
            prod.introductionTime = newProd.introductionTime;
            prod.productModel = newProd.productModel;
            prod.memoryCard = newProd.memoryCard;
            prod.numberProducts = newProd.numberProducts;
            prod.batterySpecifications = newProd.batterySpecifications;
            prod.operatingSystem = newProd.operatingSystem;
            prod.category = newProd.category;
            prod.titleCategory = newProd.titleCategory;
            if (newProd.pics != "")
            {
                prod.pics = newProd.pics;
            }

            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var prod = db.products.Where(i => i.Id == id).Single();

            db.products.Remove(prod);
            db.SaveChanges();

        }

        public void Edit()
        {

        }
        public Products.Product ReadById(int id)
        {
            var q = from i in db.products
                    where i.Id == id
                    select i;
            return q.Single();
        }
        public List<Products.Product> ReadByCategory(string h)
        {
            var q = from i in db.products
                    where i.titleCategory == h
                    select i;

            return q.ToList();

        }
        public List<Products.Product> ReadByTCategory(string h)
        {
            var q = from i in db.products
                    where i.category == h
                    select i;

            return q.ToList(); ;

        }
        public List<Products.Product> SearchByID(List<int> ids)
        {

            var q = from i in db.products where ids.Contains(i.Id) select i;
            return q.ToList();
        }
        public void PurchaseInvoic(List<Products.prodFactor> pf, Products.Factor factor)
        {


            var newFactor = new Products.Factor
            {
                address = factor.address,
                FactorCode = factor.FactorCode,
                timePurchase = factor.timePurchase,
                totalPrice = factor.totalPrice,
                userid = factor.userid
            };

            db.factors.Add(newFactor);
            db.SaveChanges();


            var Factor = ReadByCodeFactorInFactor(factor.FactorCode);
            List<int> ProdId = new List<int>();

            foreach (var i in pf)
            {
                var newPF = new Products.prodFactor
                {
                    FactorCode = i.FactorCode,
                    productsid = i.productsid,
                    factorid = Factor.Id,
                };
                db.fctorprod.Add(newPF);
            }



            db.SaveChanges();

        }


        public List<Products.Factor> ReadFactor()
        {
            return db.factors.ToList();
        }

        public List<int> ReadFactorCodes()
        {
            List<Products.Factor> factor = ReadFactor();


            return factor.Select(k => k.FactorCode).ToList();


        }
        public Products.Factor ReadByCodeFactorInFactor(int factorcode)
        {
            var q = from i in db.factors
                    where i.FactorCode == factorcode
                    select i;

            var Factor = q.Single();

            return Factor;

        }
        public List<Products.prodFactor> ReadByCodeFactorInProdFactor(int factorcode)
        {
            var q = from i in db.fctorprod
                    where i.FactorCode == factorcode
                    select i;

            var Factorprod = q.ToList();

            return Factorprod;

        }
        public List<KeyValuePair<int, int>> ProductsCount(List<int> prods)
        {


            var lisRep = new List<KeyValuePair<int, int>>();

            var query = prods.GroupBy(x => x)
               .Where(g => g.Count() > 1)
               .Select(y => new { Element = y.Key, Counter = y.Count() })
               .ToList();

            foreach (var item in query)
            {
                lisRep.Add(new KeyValuePair<int, int>(item.Element, item.Counter));

            }

            return lisRep;

        }
        public int PriceProdcts(List<int> ids)
        {
            if (ids != null)
            {

                var pricelist = new List<int>();
                foreach (var item in ids)
                {
                    var q = from i in db.products
                            where i.Id == item
                            select i.price;
                    int price = q.Single();
                    pricelist.Add(price);
                }
                return pricelist.Sum();

            }
            return 0;
        }
        public int TotalPriceOfFactor()
        {
            var total = db.factors.Sum(k => k.totalPrice);
            return total;
        }

        public int CountFactor()
        {
            var Counts = db.factors.Count();
            return Counts;
        }
        public List<Products.Factor> SearchFactor(string info)
        {
            if (info == null)
            {

                var q = db.factors.ToList();
                return q;
            }
            var listsearch = new List<Products.Factor>();
            var isNumeric = int.TryParse(info, out int n);


            if (isNumeric == true)
            {
                int code = Convert.ToInt32(info);
                var r = from i in db.factors
                        where i.FactorCode == code
                        select i;
                listsearch = r.ToList();

            }
            else
            {
                var q = from i in db.factors
                        where i.address.Contains(info) || i.timePurchase.Contains(info)
                        select i;
                listsearch = q.ToList();

            }


            if (listsearch.Count() > 0)
            {
                return listsearch;
            }
            else
            {
                listsearch.Add(new Products.Factor
                {
                    Id = 00,
                    FactorCode = 99999,
                    timePurchase = "یافت نشد",
                    address = "یافت نشد"
                });
                return listsearch;

            }



        }
        public void CounterProducts(List<int> prodid)
        {
            foreach (var i in prodid)
            {
                Products.Product p = ReadById(i);
                int count = p.numberProducts;
                int counter = count - 1;
                p.numberProducts = counter;
            }
            db.SaveChanges();
        }

    }
}
