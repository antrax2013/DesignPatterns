using System.Globalization;

namespace Adapter;

public class EmployeeUserAdapter : IUserAdapter<Employee>
{
    public User GetUser(Employee employee)
    {
        string[] tmp = employee.FullName.Split(' ');

        return new(Guid.NewGuid(), CultureInfo.InvariantCulture.TextInfo.ToTitleCase(tmp[0]), tmp[1].ToUpper(), employee.Id.ToString());
    }
}
