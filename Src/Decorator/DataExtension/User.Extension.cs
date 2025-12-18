namespace Decorator.DataExtension;

public sealed class ExtendedUser(string firstName, string lastName/*, int age*/)
{
    private readonly User u = new(firstName, lastName);

    //public int Age { get; set; } = age;

    public string FirstName { get => u.FirstName; }
    public string LastName { get => u.LastName; }

    public string FullName { get => $"{u.FirstName} {u.LastName}"; }
}
