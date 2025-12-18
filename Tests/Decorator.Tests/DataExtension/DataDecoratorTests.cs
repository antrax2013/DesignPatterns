using Decorator.DataExtension;
using NFluent;

namespace Decorator.Tests.DataExtension;

public class DataDecoratorTests
{

    [Test]
    public void Quand_Je_Cree_Un_Utilisateur_Etendu_Alors_Il_Contient_Un_Utilisateur_Avec_Les_Proprietes_Attendue()
    {
        // Given
        User john = new("John", "Doe");
        var expected = new { john.FirstName, john.LastName, FullName = $"{john.FirstName} {john.LastName}" };

        // When
        ExtendedUser extendedJohn = new(john.FirstName, john.LastName);

        // Then
        //Check.That(extendedJohn).Considering().Public.Properties.HasSameValueAs(expected);
        Check.That(extendedJohn).IsEqualTo(expected);
    }
}
