namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName, string LastName , string Email, string password);
    AuthenticationResult Login(string email, string password);
}