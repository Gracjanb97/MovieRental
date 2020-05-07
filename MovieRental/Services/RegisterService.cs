using DatabaseAccess.Entities;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services
{
    public class RegisterService : IRegisterService
    {

        public bool Register(RegisterFormModel registerForm)
        {
            bool output = false;

            var account = createAccountObject(registerForm);

            if(account != null)
            {
                // TODO: Register account in database
            }

            return output;
        }

        private Account createAccountObject(RegisterFormModel registerForm)
        {
            Account account = null;

            var user = new UserProfile
            {
                Username = registerForm.Username,
                Email = registerForm.Email,
                Password = CalculateHash(registerForm.Password, registerForm.Username),
                IsActive = false
            };

            account = new Account
            {
                FirstName = registerForm.FirstName,
                LastName = registerForm.LastName,
                User = user,
                Balance = 0
            };

            return account;
        }

        private string CalculateHash(string clearTextPassword, string salt)
        {
            // Convert the salted password to a byte array
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(clearTextPassword + salt);

            // Use the hash algorithm to calculate the hash
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);

            // Return the hash as a base64 encoded string to be compared to the stored password
            return Convert.ToBase64String(hash);
        }
    }
}
