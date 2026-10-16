using System.ComponentModel.DataAnnotations;

namespace LoansApp.Core.Application.DTOs.Loan
{
    public class SaveLoan
    {
        public int Id { get; set; }

        [Length(3, 50)]
        [Required(ErrorMessage = "This is a required field")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int PaymentDay { get; set; }
        
        [Required(ErrorMessage = "This is a required field")]
        public decimal MonthlyPayment { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public decimal MonthlyInterest { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public decimal MonthlyPrincipal { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The value of the loan has to be higher than 0")]
        public decimal OriginalLoanAmount { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [Range(0.01, double.MaxValue)]
        public decimal OutstandingBalance { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [Range(0, 60, ErrorMessage = "Loans are only offered for a maximum of 4 years")]
        public int RemainingInstallments { get; set; }
    }
}
