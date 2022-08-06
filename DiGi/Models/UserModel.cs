using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordTwo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public IFormFile pic { get; set; }
        public int admin { get; set; }


    }
}
