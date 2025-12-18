using Facade.Entities;

namespace Facade.Services;

internal class UserInternalServices
{
    internal Task<User> GetUser(int id)
    {
        return Task.FromResult(new User(id, string.Empty, [], []));
    }

}
