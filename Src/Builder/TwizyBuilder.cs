using Builder.Components;

namespace Builder;

public class TwizyBuilder : IVehicleBuilder
{
    private readonly Vehicle v = new("Renault Twizy");

    public IVehicleBuilder AddEngine()
    {
        v.AddEngine(new Engine("Electric"));
        return this;
    }
    public IVehicleBuilder AddSeats()
    {
        v.AddSeats(2);
        return this;
    }

    public Vehicle Build() => v;
}
