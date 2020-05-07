using MovieRental.Models;

namespace MovieRental.Services
{
    public interface IRegisterService
    {
        bool Register(RegisterFormModel registerForm);
    }
}