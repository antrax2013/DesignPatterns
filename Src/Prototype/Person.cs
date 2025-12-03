namespace Prototype;

public class Person
{
    public Person(string lastName, string firstName, Address address)
    {
        LastName = lastName;
        FirstName = firstName;
        Address = address;
        Id = GenerateId();
    }

    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Address Address { get; set; }

    public string Id { get; init; }

    private string GenerateId() => $"{Address.Country[0..2]}{FirstName[0]}{LastName[0..2]}";

}
