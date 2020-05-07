namespace MovieRental.User
{
    public interface ILoggedInUser
    {
        bool Login(string username, string password);
        bool Logout();
    }
}