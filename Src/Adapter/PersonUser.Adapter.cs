using System.Globalization;

namespace Adapter;

public class PersonUserAdapter : IUserAdapter<Person>
{
    public User GetUser(Person person)
    {
        return new(Guid.NewGuid(), CultureInfo.InvariantCulture.TextInfo.ToTitleCase(person.FirstName), person.LastName.ToUpper(), person.Id.ToString());
    }
}
