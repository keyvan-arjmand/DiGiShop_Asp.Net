using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordTwo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public IFormFile pic { get; set; }
        public string pic2 { get; set; }
        public int admin { get; set; }
        public int code { get; set; }


    }
}
