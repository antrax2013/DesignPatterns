using Builder.Components;

namespace Builder;

public class Porsche911Builder : IVehicleBuilder, IPremiumVehicleBuilder // to respect interfaces segregation
{
    private readonly Vehicle v = new("Porsche 911");

    public IVehicleBuilder AddEngine()
    {
        v.AddEngine(new Engine("Petrol"));
        return this;
    }

    public IVehicleBuilder AddOptions()
    {
        v.AddOptions([new("Automatic Gearbox"), new("Air Conditioning")]);
        return this;
    }

    public IVehicleBuilder AddSeats()
    {
        v.AddSeats(5);
        return this;
    }

    public Vehicle Build() => v;
}
