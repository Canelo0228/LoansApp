namespace LoansApp.Core.Application.DTOs.Record
{
    public class ViewRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal MonthlyPrincipal { get; set; }
        public decimal OriginalLoanAmount { get; set; }
        public decimal TotalInterestIncome { get; set; }
    }
}
