using MovieRental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.User
{
    public class LoggedInUser : ILoggedInUser
    {
        private IAuthenticationService _authenticationService { get; set; }

        public int UserId { get; set; }

        public int AccountId { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public LoggedInUser(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public bool Login(string username, string password)
        {
            bool output = false;

            // TODO: Make login function
            var account = _authenticationService.AuthenticateUser(username, password);

            if (account != null)
            {
                this.UserId = account.User.Id;
                this.AccountId = account.Id;
                this.Username = account.User.Username;
                this.Email = account.User.Email;
                this.FirstName = account.FirstName;
                this.LastName = account.LastName;

                output = true;
            }
            else
                throw new UnauthorizedAccessException();

            return output;
        }

        public bool Logout()
        {
            bool output = false;

            // TODO: Make logout function

            return output;
        }
    }
}
