namespace LoansApp.Core.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public string CustomerName {  get; set; } = string.Empty;
        public int PaymentDay { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal MonthlyPrincipal { get; set; }
        public decimal OriginalLoanAmount { get; set; }
        public decimal OutstandingBalance { get; set; }
        public int RemainingInstallments { get; set; }

        public ICollection<Payment> Payments { get; set; }
                = new List<Payment>();
    }
}
