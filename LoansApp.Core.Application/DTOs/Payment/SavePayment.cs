using System.ComponentModel.DataAnnotations;

namespace LoansApp.Core.Application.DTOs.Payment
{
    public class SavePayment
    {
        public int Id { get; set; }
        
        [Required]
        public DateOnly Date { get; set; }
        
        [Required]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "You need to select a loan to apply a payment for.")]
        public int LoanId { get; set; }
    }
}
