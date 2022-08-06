using System;
using System.Collections.Generic;
using System.Text;

namespace Be
{
  public  class Products
    {
      public class Product
        {
            public int Id { get; set; }
            public string nameProduct { get; set; }
            public string price { get; set; }
            public string pics { get; set; }
            public string description { get; set; }//توضیحات محصول
            public string camra { get; set; }//دوربین
            public string dimensions { get; set; } //ابعاد محصول
            public string weight { get; set; }//وزن محصول
            public string screen { get; set; }//نوع فناوری صفحه نمایش
            public string screenSize { get; set; }//اندازه صفحه نمایش
            public string bodyStructure { get; set; }//نوع بدنه ی محصول
            public string specialFeatures { get; set; }//ویژگی های خاص محصول
            public string introductionTime { get; set; }//زمان عرضه محصول
            public string productModel { get; set; }//مدل محصول
            public string memoryCard { get; set; }//کارت حافظه
            public string numberProducts { get; set; }//تعداد موجودی محصول
            public string batterySpecifications { get; set; }//توضیحات باطری
            public string operatingSystem { get; set; }//سیستم عامل
            public string category { get; set; }//دسته بندی
            public string titleCategory { get; set; }//عنوان دسته بندی
        }

        public class Factor
        {
            public int  Id { get; set; }
            public List<Product> product { get; set; }
            public Users.Beusers user { get; set; }
            public string totalPrice { set; get; }
            public string address { set; get; }
            public string timePurchase { get; set; }

        }


    }
}
