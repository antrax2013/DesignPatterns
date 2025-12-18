namespace Composite;

public sealed class Entreprise(string name, IEnumerable<Entreprise>? subsidiaries, IEnumerable<Invoice>? invoices) : ATreeNodeElement
{
    public string Name { get; set; } = name;
    public IEnumerable<Entreprise>? Subsidiaries { get; set; } = subsidiaries;

    public IEnumerable<Invoice>? Invoices { get; set; } = invoices;

    public decimal CalculateRevenue() => Invoices?.Sum(i => i.Amount) ?? 0;
}
