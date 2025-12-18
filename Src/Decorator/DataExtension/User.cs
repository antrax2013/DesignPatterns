namespace Decorator.DataExtension;

public sealed class User(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

}
