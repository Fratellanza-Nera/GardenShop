using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GardenShop.Data;
using GardenShop.Models;
using System.Security.Cryptography; 
using System.Text;                 


namespace GardenShop.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService()
        {
            _context = new ApplicationDbContext();
        }


          private string HashPassword(string password)
          {
               using (var md5 = System.Security.Cryptography.MD5.Create())
               {
                    var inputBytes = System.Text.Encoding.ASCII.GetBytes(password + "twutm2018"); // salt
                    var hashBytes = md5.ComputeHash(inputBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
               }
          }

          public bool Register(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
                return false;

               string hashedPassword = HashPassword(password);

               _context.Users.Add(new User { Username = username, Password = hashedPassword });

               _context.SaveChanges();
            return true;
        }

        public bool Login(string username, string password)
        {
               string hashedPassword = HashPassword(password); 

               return _context.Users.Any(u => u.Username == username && u.Password == password);
        }
    }
}

// This code defines a UserService class that handles user registration and login functionality.