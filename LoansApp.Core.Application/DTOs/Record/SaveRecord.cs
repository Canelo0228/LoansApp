using System.ComponentModel.DataAnnotations;

namespace LoansApp.Core.Application.DTOs.Record
{
    public class SaveRecord
    {
        public int Id { get; set; }
        
        [Required]
        public string CustomerName { get; set; }
        
        [Required]
        public DateOnly EndDate { get; set; }
        
        [Required]
        public decimal MonthlyPayment { get; set; }
        
        [Required]
        public decimal MonthlyInterest { get; set; }
        
        [Required]
        public decimal MonthlyPrincipal { get; set; }
        
        [Required]
        public decimal OriginalLoanAmount { get; set; }
        
        [Required]
        public decimal TotalInterestIncome { get; set; }
    }
}
