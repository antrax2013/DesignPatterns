using Facade.Entities;

namespace Facade.Services;

internal class VehicleInternalServices
{
    internal Task<IEnumerable<Vehicle>> GetVehiclesByUserId(int id)
    {
        return Task.FromResult<IEnumerable<Vehicle>>([new Vehicle()]);
    }
}
