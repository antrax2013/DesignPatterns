using NFluent;

namespace Bridge.Tests;

public class TaxeCalculatorsTests
{
    [Test]
    public void Quand_On_Clacule_La_Tva_Francaise_D_Une_Liste_De_Courses_Alors_On_Obtient_Le_Total_TTC_Attendu_Different_Du_Total()
    {
        // Given
        IEnumerable<Item> items = [
                new("Pain", 2, 1.00m, ItemCategory.Food),
                new ("Livre", 3, 10.00m, ItemCategory.Book),
                new ("Stylo", 5, 2.00m, ItemCategory.Other),
                new ("Jean", 2, 50.00m, ItemCategory.Other),
                new ("Timbre", 10, 1m, ItemCategory.None)
            ];
        ITaxeCalculator taxeCalculator = new FrenchTaxeCalculator();
        Invoice invoice = new(items, taxeCalculator);
        decimal expectedTotalTTC = 2.11m + 31.65m + 12 + 120m + 10; //175.76m


        // When
        decimal actualTotalTTC = invoice.TotalTTC;
        decimal actualTotal = invoice.Total;

        // Then
        Check.That(actualTotalTTC).IsEqualTo(expectedTotalTTC);
        Check.That(actualTotalTTC).Not.IsEqualTo(actualTotal);
    }

    [Test]
    public void Quand_On_Clacule_La_Tva_Degressive_D_Une_Liste_De_Courses_Faite_En_France_Alors_On_Obtient_Le_Total_TTC_Attendu_Different_Du_Total()
    {
        // Given
        IEnumerable<Item> items = [
                new("Pain", 2, 1.00m, ItemCategory.Food),
                new ("Livre", 3, 10.00m, ItemCategory.Book),
                new ("Stylo", 5, 2.00m, ItemCategory.Other),
                new ("Jean", 2, 50.00m, ItemCategory.Other),
                new ("Timbre", 10, 1m, ItemCategory.None),
                new ("Pomme", 3, 0.45m, ItemCategory.Food)
            ];
        ITaxeCalculator taxeCalculator = new DregressiveRateTaxeCalculator();
        Invoice invoice = new(items, taxeCalculator);
        decimal expectedTotalTTC = 118 + 35.1m + 11.6m + 11.5m + 2.3m + 1.5525m; //175.76m


        // When
        decimal actualTotalTTC = invoice.TotalTTC;
        decimal actualTotal = invoice.Total;

        // Then
        Check.That(actualTotalTTC).IsEqualTo(expectedTotalTTC);
        Check.That(actualTotalTTC).Not.IsEqualTo(actualTotal);
    }
}
