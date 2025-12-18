namespace Bridge;

public enum ItemCategory
{
    Food,
    Book,
    Vehicle,
    Other,
    None
}

public record Item(string Name, int Quantity, decimal Price, ItemCategory Category);