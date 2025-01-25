using eCommerce.Core.DTOs;

namespace eCommerce.Core.ServiceContracts;

public interface IUsersService
{
    /// <summary>
    /// Logs in a user.
    /// </summary>
    /// <param name="loginRequest">The request containing user login details.</param>
    /// <returns>An AuthenticationResponse containing the result of the login attempt.</returns>
    Task<AuthenticationResponse?> Login(LoginRequest loginRequest);

    /// <summary>
    /// Registers a new user.
    /// </summary>
    /// <param name="registerRequest">The request containing user registration details.</param>
    /// <returns>An AuthenticationResponse containing the result of the registration attempt.</returns>
    Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
}