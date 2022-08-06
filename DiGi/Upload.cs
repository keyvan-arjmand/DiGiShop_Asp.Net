using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi
{
    public class Upload
    {

        //upload photo = "string" addres 

        private readonly IWebHostEnvironment _webHostEnvironment;
        public Upload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string Uploadfile(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\image\\users\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);



            return file.FileName;
        }
        public string Uploadvideo(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\videos\\users\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);

            path = path.Split("wwwroot")[1];

            //upload video = "string" addres 

            return path;
        }

    }
}
