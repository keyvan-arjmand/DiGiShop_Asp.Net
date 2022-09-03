using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Models
{
    public class FactorModel
    {
        public int Id { get; set; }
        public int totalPrice { set; get; }
        public string address { set; get; }
        public string timePurchase { get; set; }
        public List<Be.Products.Product> products { get; set; }
        public Be.Users.Beusers user { get; set; }
        public int CodeFactor { get; set; }
    }
}
