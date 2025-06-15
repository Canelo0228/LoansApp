namespace LoansApp.Core.Domain.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string loanNumber { get; set; }
        public string EndDate { get; set; }
        public string MonthlyIncome { get; set; }
        public string MonthlyInterest { get; set; }
        public string MonthlyCapital { get; set; }
        public string LoanValue { get; set; }
        public string TotalInterestIncomes { get; set; }

    }
}
