namespace LoansApp.Core.Application.DTOs.Loan
{
    public class ViewLoan
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int PaymentDay { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal MonthlyPrincipal { get; set; }
        public decimal OriginalLoanAmount { get; set; }
        public decimal OutstandingBalance { get; set; }
        public int RemainingInstallments { get; set; }
    }
}