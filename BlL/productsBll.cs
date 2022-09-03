using System;
using System.Collections.Generic;
using System.Text;
using Dal;
using Be;
namespace BlL
{
    public class productsBll
    {
        productsDal dl = new productsDal();
        public void Create(Products.Product h)
        {
            dl.Create(h);
        }
        public List<Products.Product> Read()
        {
            return dl.Read();
        }
        public List<Products.Product> Search(string h)
        {
            return dl.Search(h);
        }
        public void Delete(int id)
        {
            dl.Delete(id);

        }
        public Products.Product ReadById(int id)
        {
            return dl.ReadById(id);
        }

        public void EditProducts(Products.Product newProd)
        {
            dl.EditProducts(newProd);
        }

        public List<Products.Product> ReadByCategory(string h)
        {
            return dl.ReadByCategory(h);
        }
        public List<Products.Product> ReadByTCategory(string h)
        {
            return dl.ReadByTCategory(h);
        }
        public List<Products.Product> SearchByID(List<int> ids)
        {
            return dl.SearchByID(ids);
        }
        public void PurchaseInvoic(List<Products.prodFactor> pf, Products.Factor factor)
        {
            dl.PurchaseInvoic(pf, factor);
        }
        public List<Products.Factor> ReadFactor()
        {
            return dl.ReadFactor();
        }
        public List<int> ReadFactorCodes()
        {
            return dl.ReadFactorCodes();
        }


        public Products.Factor ReadByCodeFactorInFactor(int factorcode)
        {
            return dl.ReadByCodeFactorInFactor(factorcode);
        }
        public List<Products.prodFactor> ReadByCodeFactorInProdFactor(int factorcode)
        {
            return dl.ReadByCodeFactorInProdFactor(factorcode);
        }

        public List<KeyValuePair<int, int>> ProductsCount(List<int> prods)
        {
            return dl.ProductsCount(prods);
        }

        public int PriceProdcts(List<int> ids)
        {
            return dl.PriceProdcts(ids);
        }

        public int TotalPriceOfFactor()
        {
            return dl.TotalPriceOfFactor();
        }
        public int CountFactor()
        {
            return dl.CountFactor();
        }
        public List<Products.Factor> SearchFactor(string info)
        {
            return dl.SearchFactor(info);
        }


    }
}
