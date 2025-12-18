namespace Composite
{
    public static class GroupRevenues
    {
        public static decimal CalculateRevenues(Entreprise entreprise)
        {
            decimal result = entreprise.CalculateRevenue();
            entreprise?.Subsidiaries?.ToList().ForEach(subsidiary => result += CalculateRevenues(subsidiary));

            return result;
        }
    }
}
