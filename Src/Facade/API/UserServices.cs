using Facade.Entities;
using Facade.Services;

namespace Facade.API;

public sealed class UserServices : IUserServices
{
    // DI would be better, but for simplicity, we will just create instances here.
    readonly PetInternalServices petInternalServices = new();
    readonly VehicleInternalServices vehicleInternalServices = new();
    readonly UserInternalServices userInternalServices = new();

    public Task<User> GetUser(int id)
    {
        return Task.FromResult(
            userInternalServices.GetUser(id).Result
            with
            {
                Pets = [.. petInternalServices.GetPetsByUserId(id).Result],
                Vehicles = [.. vehicleInternalServices.GetVehiclesByUserId(id).Result]
            }
        );
    }
}
