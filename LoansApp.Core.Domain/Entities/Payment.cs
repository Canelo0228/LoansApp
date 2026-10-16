namespace LoansApp.Core.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }

        public int LoanId { get; set; }
        public Loan Loan { get; set; } = null!;
    }
}
