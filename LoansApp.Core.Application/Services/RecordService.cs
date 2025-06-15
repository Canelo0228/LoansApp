using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Services
{
    public class RecordService : GenericService<SaveRecord, ViewRecord, Record>, IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IMapper _mapper;

        public RecordService(IRecordRepository recordRepository, IMapper mapper) : base(recordRepository, mapper)
        {
            _recordRepository = recordRepository;
            _mapper = mapper;
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
