namespace Bridge;

public class Invoice(IEnumerable<Item> items, ITaxeCalculator taxeCalculator)
{
    public decimal TotalTTC => taxeCalculator.Compute(items);
    public decimal Total => items.Sum(item => item.Price * item.Quantity);
}
