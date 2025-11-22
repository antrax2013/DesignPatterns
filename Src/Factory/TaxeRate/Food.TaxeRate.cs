namespace Factory.TaxeRate;

public sealed class FoodTaxeRate : ITaxeRate
{
    public decimal GetRate() => 0.05m;
}
