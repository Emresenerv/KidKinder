﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
    }
}