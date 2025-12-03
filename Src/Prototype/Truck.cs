
using System.Text.Json;

namespace Prototype;

public class Truck(string licensePlat, Person owner) : AVehicle
{
    public string LicensePlat { get; set; } = licensePlat;
    public Person? Owner { get; set; } = owner;

    public override Truck Clone()
    {
        string tmp = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<Truck>(tmp)!;
    }
}
