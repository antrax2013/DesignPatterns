namespace Prototype;

public class Car(string licensePlat, Person? owner) : AVehicle
{
    public string LicensePlat { get; set; } = licensePlat;
    public Person? Owner { get; set; } = owner;


    public override Car Clone()
    {
        Person? owner = null;
        string licencePlat = this.LicensePlat;

        if (Owner is not null)
        {
            owner = this.Owner is null ? null : new Person(
                this.Owner.FirstName,
                this.Owner.LastName,
                new Address()
                {
                    Street = this.Owner.Address.Street,
                    City = this.Owner.Address.City,
                    Country = this.Owner.Address.Country
                });
        }
        return new Car(licencePlat, owner);
    }
}
