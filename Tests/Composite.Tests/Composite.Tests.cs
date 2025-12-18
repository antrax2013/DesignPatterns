using NFluent;

namespace Composite.Tests
{
    public class CompositeTests
    {

        [Test]
        public void Quand_On_Calcule_Le_Chiffre_D_Affaire_Du_Groupe_Alors_On_Obtient_Le_Chiffre_Attendu()
        {
            // Given
            decimal expectedRevenues = 10000m;
            Entreprise subsidiary1_1 = new("subsidiary1_1", null, [
                new Invoice(1000m),
                new Invoice(2000m)
                ]);

            Entreprise subsidiary1_2 = new("subsidiary1_2", null, [
                   new Invoice(3000m),
                   new Invoice(1000m)
            ]);


            Entreprise subsidiary1 = new("subsidiary1", [subsidiary1_1, subsidiary1_2
                ], [
                   new Invoice(1000m)
            ]);

            Entreprise subsidiary2 = new("subsidiary2", null, [
                   new Invoice(2000m)
            ]);

            Entreprise main = new("main", [subsidiary1, subsidiary2], null);


            // When
            decimal revenue = GroupRevenues.CalculateRevenues(main);

            // Then
            Check.That(revenue).IsEqualTo(expectedRevenues);
        }
    }
}
