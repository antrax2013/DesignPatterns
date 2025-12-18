
namespace Composite;

public sealed class Invoice(decimal amount) : ATreeNodeElement
{
    public decimal Amount { get; set; } = amount;
}
