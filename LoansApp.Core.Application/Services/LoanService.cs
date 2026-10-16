using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;

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

        public async Task<List<ViewLoan>> GetAllWithFilterAsync(string property, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                var allLoans = await _loanRepository.GetAllAsync();
                return _mapper.Map<List<ViewLoan>>(allLoans);
            }

            List<Loan> loans;

            switch (property)
            {
                case nameof(Loan.CustomerName):
                    loans = await _loanRepository.GetAllAsync(
                        x => x.CustomerName != null &&
                             x.CustomerName.Contains(value));
                    break;

                case nameof(Loan.MonthlyPayment):
                    if (!decimal.TryParse(value, out var payment))
                        throw new ArgumentException(
                            "Monthly payment must be a valid number.");

                    loans = await _loanRepository.GetAllAsync(
                        x => x.MonthlyPayment == payment);
                    break;

                case nameof(Loan.OriginalLoanAmount):
                    if (!decimal.TryParse(value, out var amount))
                        throw new ArgumentException(
                            "The original amount must be a valid number.");

                    loans = await _loanRepository.GetAllAsync(
                        x => x.OriginalLoanAmount == amount);
                    break;

                default:
                    throw new ArgumentException(
                        "The selected field is not valid.",
                        nameof(property));
            }

            return _mapper.Map<List<ViewLoan>>(loans);
        }
    }
}
