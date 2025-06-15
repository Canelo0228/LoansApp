using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface ILoanService
    {
        Task AddAsync(SaveLoan saveLoan);

        Task UpdateAsync(SaveLoan saveLoan, int id);

        Task DeleteAsync(int id);

        Task<List<ViewLoan>> GetAllAsync();

        Task<ViewLoan> GetByIdAsync(int id);

        Task<List<ViewLoan>> GetAllWithFilter(string property, string value);

        DataTable MapLoansToDataTable(List<ViewLoan> loans);
    }
}
