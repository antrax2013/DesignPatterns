using NFluent;

namespace Builder.Tests;

public class BuilderTests
{

    [Test]
    public void Quand_On_Demande_La_Construction_D_Une_Prosche_911_Alors_On_Obtient_Un_Vehicule_Avec_Des_Options()
    {
        // When
        Vehicle porsche = Worker.PrepareVehicule(new Porsche911Builder());

        // Then
        Check.That(porsche.Name).IsEqualTo("Porsche 911");
        Check.That(porsche.Engine!.MotorFuelType).IsEqualTo("Petrol");
        Check.That(porsche.Options).HasSize(2);
        Check.That(porsche.Seats).HasSize(5);
    }

    [Test]
    public void Quand_On_Demande_La_Construction_D_Une_Twizzy_Alors_On_Obtient_Un_Vehicule_Sans_Options()
    {
        // When
        Vehicle twizzy = Worker.PrepareVehicule(new TwizyBuilder());

        // Then
        Check.That(twizzy.Name).IsEqualTo("Renault Twizy");
        Check.That(twizzy.Engine!.MotorFuelType).IsEqualTo("Electric");
        Check.That(twizzy.Options).IsNull();
        Check.That(twizzy.Seats).HasSize(2);
    }
}
