using Factory.TaxeRate;

namespace Factory.Factory;

public sealed class UnTaxedTaxeRateFactory : ITaxeRateFactory
{
    public static ITaxeRate GetInstance() => new UnTaxedRate();
}
