﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Be
{
    public class Users
    {
        public class Beusers
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string family { get; set; }
            public string email { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string phoneNumber { get; set; }
            public string pic { get; set; }
            public int admin { get; set; }
        }
        public class UserApp : IdentityUser

        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }




    }
}
