namespace Builder;

public interface IVehicleBuilder
{
    IVehicleBuilder AddSeats();
    IVehicleBuilder AddEngine();
    Vehicle Build();
}
