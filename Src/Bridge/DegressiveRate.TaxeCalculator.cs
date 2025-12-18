

namespace Bridge;

public class DregressiveRateTaxeCalculator : ITaxeCalculator
{
    private const decimal maxThresold = 0.18m;
    private const decimal minThresold = 0.15m;
    private const decimal step = 0.01m;

    private static decimal GetTaxRate(int index)
    {
        return 1 + Math.Max(maxThresold - index * step, minThresold);
    }

    public decimal Compute(IEnumerable<Item> items)
    {
        decimal total = 0m;
        var orderedItemsByDescendingPricesAndQuantity = items.OrderByDescending(item => item.Price).ThenByDescending(item => item.Quantity);

        for (int i = 0; i < orderedItemsByDescendingPricesAndQuantity.Count(); i++)
        {
            var item = orderedItemsByDescendingPricesAndQuantity.ElementAt(i);
            total += item.Price * item.Quantity * GetTaxRate(i);
        }

        return total;
    }
}
