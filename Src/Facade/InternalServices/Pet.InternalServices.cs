using Facade.Entities;

namespace Facade.Services;

internal class PetInternalServices
{
    internal Task<IEnumerable<Pet>> GetPetsByUserId(int id)
    {
        return Task.FromResult<IEnumerable<Pet>>([new Pet()]);
    }
}
