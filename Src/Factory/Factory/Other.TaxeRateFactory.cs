using Factory.TaxeRate;

namespace Factory.Factory;

public sealed class OtherTaxeRateFactory : ITaxeRateFactory
{
    public static ITaxeRate GetInstance() => new OtherTaxeRate();
}
