using NFluent;

namespace Factory.Test;
public class FactoryTests
{
    [Test]
    public void Quand_Je_Calcule_Le_Total_De_Ma_Facture_Alors_J_Obtients_Le_Total_Attendu()
    {
        // Given
        Invoice.Invoice invoice = new(
            [
                new Invoice.Item(new Product.Product("Jean", 50m, Product.ProductCategory.Other), 2),
                new Invoice.Item(new Product.Product("Apple", 0.5m, Product.ProductCategory.Food), 5),
                new Invoice.Item(new Product.Product("Offence", 135, Product.ProductCategory.Untaxed), 1),
            ]
        );

        // When
        decimal total = invoice.GetTaxedTotal();

        // Then
        Check.That(total).IsEqualTo(257.625m);
    }
}
