using LoansApp.Core.Application.DTOs.Record;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IRecordService
    {
        Task AddAsync(SaveRecord saveDTO);

        Task<List<ViewRecord>> GetAllAsync();

        DataTable MapRecordsToDataTable(List<ViewRecord> entities);
    }
}
