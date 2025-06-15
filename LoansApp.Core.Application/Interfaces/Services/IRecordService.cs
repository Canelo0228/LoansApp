using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Domain.Entities;
using System.Data;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IRecordService : IGenericService<SaveRecord, ViewRecord, Record>
    {
        DataTable MapRecordsToDataTable(List<ViewRecord> entities);
    }
}
