namespace Factory.Invoice;


public record class Item(Product.Product Product, int Quantity)
{
}