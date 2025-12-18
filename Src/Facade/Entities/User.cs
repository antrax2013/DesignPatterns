namespace Facade.Entities;

public record User(int Id, string Name, List<Pet> Pets, List<Vehicle> Vehicles);
