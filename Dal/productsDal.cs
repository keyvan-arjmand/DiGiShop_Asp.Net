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
                    where i.nameProduct.Contains(h) || i.price.Contains(h) || i.productModel.Contains(h) || i.nameProduct.Contains(h) || i.operatingSystem.Contains(h)
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
            if (newProd.pics != null) { prod.pics = newProd.pics; }
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

            return q.ToList(); ;

        }
        public List<Products.Product> ReadByTCategory(string h)
        {
            var q = from i in db.products
                    where i.category == h
                    select i;

            return q.ToList(); ;

        }
    }
}
