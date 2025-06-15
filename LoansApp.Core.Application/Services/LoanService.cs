using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;
using System.Linq.Expressions;

namespace LoansApp.Core.Application.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;

        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task AddAsync(SaveLoan saveLoan)
        {
            Loan loan = new()
            {
                Name = saveLoan.Name,
                Number = saveLoan.Number,
                Capital = saveLoan.Capital,
                Interest = saveLoan.Interest,
                RemainingFees = saveLoan.RemainingFees,
                PayDay = saveLoan.PayDay,
                TotalIncome = saveLoan.TotalIncome,
                LoanBalance = saveLoan.LoanBalance,
                Value = saveLoan.Value,
            };
            await _loanRepository.AddAsync(loan);
        }

        public async Task UpdateAsync(SaveLoan saveLoan, int id)
        {
            Loan entity = new()
            {
                ID = saveLoan.ID,
                Name = saveLoan.Name,
                Number = saveLoan.Number,
                Capital = saveLoan.Capital,
                Interest = saveLoan.Interest,
                RemainingFees = saveLoan.RemainingFees,
                PayDay = saveLoan.PayDay,
                TotalIncome = saveLoan.TotalIncome,
                LoanBalance = saveLoan.LoanBalance,
                Value = saveLoan.Value,
            };
            await _loanRepository.UpdateAsync(entity, id);
        }

        public async Task DeleteAsync(int id)
        {
            var loan = await _loanRepository.GetByIdAsync(id);
            await _loanRepository.DeleteAsync(loan);
        }

        public async Task<List<ViewLoan>> GetAllAsync()
        {
            var loanList = await _loanRepository.GetAllAsync();

            return loanList.Select(loan => new ViewLoan
            {
                ID = loan.ID,
                Name = loan.Name,
                Number = loan.Number,
                Capital = loan.Capital,
                Interest = loan.Interest,
                RemainingFees = loan.RemainingFees,
                PayDay = loan.PayDay,
                TotalIncome = loan.TotalIncome,
                LoanBalance = loan.LoanBalance,
                Value = loan.Value,
            }).ToList();
        }

        public async Task<ViewLoan> GetByIdAsync(int id)
        {
            var loan = await _loanRepository.GetByIdAsync(id);

            ViewLoan viewLoan = new()
            {
                Name = loan.Name,
                Number = loan.Number,
                Capital = loan.Capital,
                Interest = loan.Interest,
                RemainingFees = loan.RemainingFees,
                PayDay = loan.PayDay,
                TotalIncome = loan.TotalIncome,
                LoanBalance = loan.LoanBalance,
                Value = loan.Value,
            };

            return viewLoan;
        }

        public async Task<List<ViewLoan>> GetAllWithFilter(string property, string value)
        {
            var parameter = Expression.Parameter(typeof(Loan), "x");
            var propertyAccess = Expression.PropertyOrField(parameter, property);
            var valueExpression = Expression.Constant(value);
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

            var containsCall = Expression.Call(propertyAccess, containsMethod, valueExpression);
            var lambda = Expression.Lambda<Func<Loan, bool>>(containsCall, parameter);
            var filteredLoans = await _loanRepository.GetAllAsync(lambda);
            return filteredLoans.Select(loan => new ViewLoan()
            {
                ID = loan.ID,
                Name = loan.Name,
                Number = loan.Number,
                Capital = loan.Capital,
                Interest = loan.Interest,
                PayDay = loan.PayDay,
                RemainingFees = loan.RemainingFees,
                Value = loan.Value,
                LoanBalance = loan.LoanBalance,
                TotalIncome = loan.TotalIncome,
            }).ToList();
        }

        public DataTable MapLoansToDataTable(List<ViewLoan> loans)
        {
            DataTable table = new();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("PayDay", typeof(string));
            table.Columns.Add("Monthly Income", typeof(string));
            table.Columns.Add("Interest", typeof(string));
            table.Columns.Add("Capital", typeof(string));
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Loan Balance", typeof(string));
            table.Columns.Add("Remaining Fees", typeof(string));

            foreach (var loan in loans)
            {
                table.Rows.Add(
                    loan.ID,
                    loan.Name,
                    loan.Number,
                    loan.PayDay,
                    loan.TotalIncome,
                    loan.Interest,
                    loan.Capital,
                    loan.Value,
                    loan.LoanBalance,
                    loan.RemainingFees
                );
            }

            return table;
        }
    }
}
