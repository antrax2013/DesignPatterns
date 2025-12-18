

namespace Bridge;

public class FrenchTaxeCalculator : ITaxeCalculator
{
    private static decimal GetTaxRate(ItemCategory category)
    {
        return 1 + category switch
        {
            ItemCategory.Food or ItemCategory.Book => 0.055m,
            ItemCategory.None => 0.0m,
            _ => 0.20m,
        };
    }

    public decimal Compute(IEnumerable<Item> items)
    {
        return items.Sum(item => item.Price * item.Quantity * GetTaxRate(item.Category));
    }
}
