﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GardenShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Хранится в открытом виде, можно заменить на хэш позже
    }
}

