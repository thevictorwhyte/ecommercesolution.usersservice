using eCommerce.Core.DTOs;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services;

internal class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
    {
        ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

        if(user == null)
        {
            return null;
        }

        return new AuthenticationResponse(user.UserId, user.Email, user.PersonName, user.Gender, "Token", Success: true);
    }

    public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
    {
        ApplicationUser user = new ApplicationUser()
        {
            Email = registerRequest.Email,
            Password = registerRequest.Password,
            PersonName = registerRequest.PersonName,
            Gender = registerRequest.Gender.ToString()
        };

        ApplicationUser? registeredUser = await _usersRepository.AddUser(user);

        if(registeredUser == null)
        {
            return null;
        }

        return new AuthenticationResponse(registeredUser.UserId, registeredUser.Email, registeredUser.PersonName, registeredUser.Gender, "Token", Success: true);
    }
}