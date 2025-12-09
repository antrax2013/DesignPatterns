using Builder.Components;

namespace Builder;

public class Vehicle(string name)
{
    public string Name { get; init; } = name;
    public List<Seat> Seats { get; init; } = [];

    public Engine? Engine { get; private set; }

    public List<Option>? Options { get; private set; }

    internal void AddEngine(Engine engine) => Engine = engine;
    internal void AddSeats(int numberOfSeat)
    {
        for (int i = 0; i < numberOfSeat; i++)
            Seats.Add(new Seat());
    }

    internal void AddOptions(IEnumerable<Option> options) => Options = [.. options];

}
