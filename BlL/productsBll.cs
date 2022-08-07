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
        public List<Products.Product> SearchByID(List<int> ids)
        {
            return dl.SearchByID(ids);
        }
    }
}
