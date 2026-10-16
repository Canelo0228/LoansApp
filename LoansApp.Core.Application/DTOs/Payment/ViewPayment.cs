namespace LoansApp.Core.Application.DTOs.Payment
{
    public class ViewPayment
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }

        public int LoanID { get; set; }
        public Domain.Entities.Loan Loan { get; set; }
    }
}
