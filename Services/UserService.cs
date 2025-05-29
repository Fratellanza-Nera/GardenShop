using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GardenShop.Data;
using GardenShop.Models;

namespace GardenShop.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService()
        {
            _context = new ApplicationDbContext();
        }

        public bool Register(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
                return false;

            _context.Users.Add(new User { Username = username, Password = password });
            _context.SaveChanges();
            return true;
        }

        public bool Login(string username, string password)
        {
            return _context.Users.Any(u => u.Username == username && u.Password == password);
        }
    }
}

// This code defines a UserService class that handles user registration and login functionality.