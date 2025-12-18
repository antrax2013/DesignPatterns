using Facade.Entities;

namespace Facade.API;

public interface IUserServices
{
    Task<User> GetUser(int id);
}
