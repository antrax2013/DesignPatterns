using Factory.TaxeRate;

namespace Factory.Factory
{
    public interface ITaxeRateFactory
    {
        static abstract ITaxeRate GetInstance();
    }
}