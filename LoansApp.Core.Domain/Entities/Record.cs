namespace LoansApp.Core.Domain.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateOnly EndDate { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal MonthlyPrincipal { get; set; }
        public decimal OriginalLoanAmount { get; set; }
        public decimal TotalInterestIncome { get; set; }
    }
}
