using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface ILoanService : IGenericService<SaveLoan, ViewLoan, Loan>
    {
        Task<List<ViewLoan>> GetAllWithFilter(string property, string value);

        DataTable MapLoansToDataTable(List<ViewLoan> loans);
    }
}
