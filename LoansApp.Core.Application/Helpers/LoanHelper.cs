namespace LoansApp.Core.Application.Helpers
{
    public static class LoanHelper
    {
        public static int CalculateInterest(int totalIncome, int capital)
        {
            return Math.Max(1, totalIncome - capital);
        }

        public static int CalculateCapital(int totalIncome, int interes)
        {
            return Math.Max(1, totalIncome - interes);
        }

        public static int CalculateFees(int valorPrestamo, int capital)
        {
            if (capital <= 0) capital = 1;
            return valorPrestamo / capital;
        }
    }
}
