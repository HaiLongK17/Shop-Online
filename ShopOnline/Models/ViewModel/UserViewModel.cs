﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Models.ViewModel
{
    public class UserViewModel
    {
        public List<ApplicationUser> applicationUsers { get; set; }
        public List<string> roles { get; set; }
    }
}
