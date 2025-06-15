using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;

        public RecordService(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task AddAsync(SaveRecord saveDTO)
        {
            Record entity = new()
            {
                Name = saveDTO.Name,
                EndDate = saveDTO.EndDate,
                loanNumber = saveDTO.loanNumber,
                LoanValue = saveDTO.LoanValue,
                MonthlyCapital = saveDTO.MonthlyCapital,
                MonthlyIncome = saveDTO.MonthlyIncome,
                MonthlyInterest = saveDTO.MonthlyInterest,
                TotalInterestIncomes = saveDTO.TotalInterestIncomes,
            };
            await _recordRepository.AddAsync(entity);
        }

        public async Task<List<ViewRecord>> GetAllAsync()
        {
            var entityList = await _recordRepository.GetAllAsync();

            return entityList.Select(entity => new ViewRecord()
            {
                Name = entity.Name,
                EndDate = entity.EndDate,
                loanNumber = entity.loanNumber,
                LoanValue = entity.LoanValue,
                MonthlyCapital = entity.MonthlyCapital,
                MonthlyIncome = entity.MonthlyIncome,
                MonthlyInterest = entity.MonthlyInterest,
                TotalInterestIncomes = entity.TotalInterestIncomes,
            }).ToList();
        }

        public DataTable MapRecordsToDataTable(List<ViewRecord> entities)
        {
            DataTable table = new();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("loanNumber", typeof(string));
            table.Columns.Add("EndDate", typeof(string));
            table.Columns.Add("MonthlyIncome", typeof(string));
            table.Columns.Add("MonthlyInterest", typeof(string));
            table.Columns.Add("MonthlyCapital", typeof(string));
            table.Columns.Add("LoanValue", typeof(string));
            table.Columns.Add("TotalInterestIncomes", typeof(string));

            foreach (var entity in entities)
            {
                table.Rows.Add(
                    entity.Name,
                    entity.loanNumber,
                    entity.EndDate,
                    entity.MonthlyIncome,
                    entity.MonthlyInterest,
                    entity.MonthlyCapital,
                    entity.LoanValue,
                    entity.TotalInterestIncomes
                );
            }

            return table;
        }
    }
}
