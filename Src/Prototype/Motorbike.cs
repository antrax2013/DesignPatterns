namespace Prototype;

public class Motorbike(string licensePlat, Person owner) : AVehicle
{
    public string LicensePlat { get; set; } = licensePlat;
    public Person? Owner { get; set; } = owner;

    public override Motorbike Clone()
    {
        return (Motorbike)MemberwiseClone();
    }
}
