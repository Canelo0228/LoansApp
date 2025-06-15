using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;
using System.Linq.Expressions;

namespace LoansApp.Core.Application.Services
{
    public class LoanService : GenericService<SaveLoan, ViewLoan, Loan>, ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;

        public LoanService(ILoanRepository loanRepository, IMapper mapper) : base(loanRepository, mapper)
        {
            _loanRepository = loanRepository;
            _mapper = mapper;
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

            return _mapper.Map<List<ViewLoan>>(filteredLoans);
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
