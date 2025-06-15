namespace LoansApp.Core.Application.DTOs.Loan
{
    public class SaveLoan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string PayDay { get; set; }
        public string TotalIncome { get; set; }
        public string Interest { get; set; }
        public string Capital { get; set; }
        public string Value { get; set; }
        public string LoanBalance { get; set; }
        public string RemainingFees { get; set; }
    }
}
