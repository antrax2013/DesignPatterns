using Factory.TaxeRate;

namespace Factory.Factory;

public sealed class FoodTaxeRateFactory : ITaxeRateFactory
{
    public static ITaxeRate GetInstance() => new FoodTaxeRate();
}
