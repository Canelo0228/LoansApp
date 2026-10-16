using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Domain.Entities;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface ILoanService : IGenericService<SaveLoan, ViewLoan, Loan>
    {
        Task<List<ViewLoan>> GetAllWithFilterAsync(string property, string value);
    }
}