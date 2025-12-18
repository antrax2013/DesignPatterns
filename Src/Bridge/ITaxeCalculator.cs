namespace Bridge;

public interface ITaxeCalculator
{
    decimal Compute(IEnumerable<Item> items);
}