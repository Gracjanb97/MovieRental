using DatabaseAccess.Entities;

namespace MovieRental.Services
{
    public interface IAuthenticationService
    {
        Account AuthenticateUser(string username, string clearTextPassword);
    }
}