using NFluent;

namespace Prototype.Tests;

public class PrototypeTests
{
    [Test]
    public void Quand_On_Clone_Profondement_Une_Voiture_Alors_On_Obtient_Une_Instance_Differente_Avec_Des_Proprietes_Independantes()
    {
        // Given
        Person paul = new("Paul", "Personne", new Address() { Street = "22 Acacia Avenue", City = "London", Country = "UK" });
        Car car = new("AA-222-KJ", paul);

        // When
        Car clone = car.Clone();

        // Then
        Check.That(clone).IsDistinctFrom(car);
        Check.That(clone.Owner).IsDistinctFrom(paul);
        Check.That(clone.Owner!.Address).IsDistinctFrom(paul.Address);
    }

    [Test]
    public void Quand_On_Clone_Profondement_Un_Camion_Alors_On_Obtient_Une_Instance_Differente_Avec_Des_Proprietes_Independantes()
    {
        // Given
        Person paul = new("Paul", "Personne", new Address() { Street = "22 Acacia Avenue", City = "London", Country = "UK" });
        Truck truck = new("AA-222-KJ", paul);

        // When
        Truck clone = truck.Clone();

        // Then
        Check.That(clone).IsDistinctFrom(truck);
        Check.That(clone.Owner).IsDistinctFrom(paul);
        Check.That(clone.Owner!.Address).IsDistinctFrom(paul.Address);
    }

    [Test]
    public void Quand_On_Clone_Superficiellement_Une_Moto_Alors_On_Obtient_Une_Instance_Differente_Avec_Des_References_D_Objets_Internes_Communes()
    {
        // Given
        Person paul = new("Paul", "Personne", new Address() { Street = "22 Acacia Avenue", City = "London", Country = "UK" });
        Motorbike moto = new("AA-222-KJ", paul);

        // When
        Motorbike clone = moto.Clone();

        // Then
        Check.That(clone).IsDistinctFrom(moto);
        Check.That(clone.Owner).IsSameReferenceAs(paul);
        Check.That(clone.Owner!.Address).IsSameReferenceAs(paul.Address);
    }

    [Test]
    public void Quand_On_Clone_Superficiellement_Un_Velo_Alors_On_Obtient_Une_Instance_Differente_Avec_Des_References_D_Objets_Internes_Communes()
    {
        // Given
        Person paul = new("Paul", "Personne", new Address() { Street = "22 Acacia Avenue", City = "London", Country = "UK" });
        Bike bike = new(paul);

        // When
        Bike clone = bike with { };

        // Then
        Check.That(clone).IsDistinctFrom(bike);
        Check.That(clone.Owner).IsSameReferenceAs(paul);
        Check.That(clone.Owner!.Address).IsSameReferenceAs(paul.Address);
    }
}
