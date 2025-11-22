namespace Factory.TaxeRate;

public sealed class UnTaxedRate : ITaxeRate
{
    public decimal GetRate() => 0m;
}
