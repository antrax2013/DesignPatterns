namespace Factory.Invoice;

public sealed class Invoice(IEnumerable<Item> Items)
{
    public decimal GetTaxedTotal() => Items.Sum(i => (i.Product.Price * i.Quantity) * (1 + Factory.TaxeRateFactory.GetInstance(i.Product.Category).GetRate()));
}
