﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sweetshop.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string  City { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }


    }
}