using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DatabaseAccess.Entities;

namespace MovieRental.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        public Account AuthenticateUser(string username, string clearTextPassword)
        {
            Account account = null;
            
            var hashedPassword = CalculateHash(clearTextPassword, username);

            // TODO: Connect with database and search user by given name



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
