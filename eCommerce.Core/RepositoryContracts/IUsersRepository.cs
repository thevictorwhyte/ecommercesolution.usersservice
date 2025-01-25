using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts;

public interface IUsersRepository
{
    /// <summary>
    /// Adds a new user to the repository.
    /// </summary>
    /// <param name="user">The user to add.</param>
    /// <returns>The added user, or null if the user could not be added.</returns>
    Task<ApplicationUser?> AddUser(ApplicationUser user);

    /// <summary>
    /// Gets a user by their email and password.
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    Task<ApplicationUser?>  GetUserByEmailAndPassword(string? email, string ? password);
}
