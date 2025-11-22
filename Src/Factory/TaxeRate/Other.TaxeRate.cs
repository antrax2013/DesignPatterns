namespace Factory.TaxeRate;

public sealed class OtherTaxeRate : ITaxeRate
{
    public decimal GetRate() => 0.2m;
}
