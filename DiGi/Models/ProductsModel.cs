using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Models
{
    public class ProductsModel
    {

        public int id { get; set; }
        public string nameProduct { get; set; }
        public string price { get; set; }
        public IFormFile pics { get; set; }
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



    }
}
