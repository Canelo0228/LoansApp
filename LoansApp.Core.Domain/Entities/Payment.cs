namespace LoansApp.Core.Domain.Entities
{
    public class Payment
    {
        public int ID { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int Amount { get; set; }
        public string MonthDay { get; set; }

        public int LoanID { get; set; }
        public Loan Loan { get; set; }
    }
}
