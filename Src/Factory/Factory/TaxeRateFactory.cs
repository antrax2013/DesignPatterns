using Factory.Product;
using Factory.TaxeRate;

namespace Factory.Factory;

public sealed class TaxeRateFactory
{
    public static ITaxeRate GetInstance(ProductCategory c)
    {
        return c switch
        {
            ProductCategory.Food => FoodTaxeRateFactory.GetInstance(),
            ProductCategory.Untaxed => UnTaxedTaxeRateFactory.GetInstance(),
            _ => OtherTaxeRateFactory.GetInstance()
        };
    }
}
