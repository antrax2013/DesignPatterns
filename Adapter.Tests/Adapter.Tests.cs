namespace Adapter.Tests;

using NFluent;

public class Tests
{
    [Test]
    public void Quand_On_Transforme_Un_Employe_En_Utilisateur_Alors_On_Obtient_L_Utilisateur_Attendu()
    {
        Guid id = Guid.NewGuid();
        // Given
        User expectedUser = new(id, "John", "DOE", id.ToString());
        Employee employee = new(id, "John Doe", "Dev Ops", "IT service");
        IUserAdapter<Employee> userAdapter = new EmployeeUserAdapter();

        // When
        User result = userAdapter.GetUser(employee);

        // Then
        Check.That(result.FirstName).IsEqualTo(expectedUser.FirstName);
        Check.That(result.LastName).IsEqualTo(expectedUser.LastName);
        Check.That(result.ExternalId).IsEqualTo(expectedUser.ExternalId);
    }

    [Test]
    public void Quand_On_Transforme_Une_Personne_En_Utilisateur_Alors_On_Obtient_L_Utilisateur_Attendu()
    {
        int id = 1024; ;
        // Given
        User expectedUser = new(Guid.NewGuid(), "John", "DOE", id.ToString());
        Person person = new(id, "john", "doe", "john.doe@entity.com");
        IUserAdapter<Person> userAdapter = new PersonUserAdapter();

        // When
        User result = userAdapter.GetUser(person);

        // Then
        Check.That(result.FirstName).IsEqualTo(expectedUser.FirstName);
        Check.That(result.LastName).IsEqualTo(expectedUser.LastName);
        Check.That(result.ExternalId).IsEqualTo(expectedUser.ExternalId);
    }
}
