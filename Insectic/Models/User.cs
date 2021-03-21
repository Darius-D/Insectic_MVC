﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Insectic.Models
{
    public class User
    {
        private string _userPassword;
        public string UserId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public string UserPassword { set => this._userPassword = value;}

        public string? ResourceGroup{ get; set; }

        public int UserRoles { get; set; }

        public string ProfilePicture { get; set; }

        public User(string password, string resourceGroup)
        {
            if (!string.IsNullOrEmpty(password))
            {
                ResourceGroup = resourceGroup;
                UserPassword = password;
            }
            else
            {
                throw new Exception("Password must not be empty");
            }
        }
    }
}
