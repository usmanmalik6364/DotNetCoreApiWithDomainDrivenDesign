


using BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstName, string LastName, string Email, string password)
    {
       return new AuthenticationResult(Guid.NewGuid(), firstName, LastName, Email, password);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "", "", email, password);
    }
}