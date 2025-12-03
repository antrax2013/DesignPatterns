namespace Prototype;

public record Bike(Person? Owner)
{
    public Person? Owner { get; set; } = Owner;
}