using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Domain.Entities;

namespace LoansApp.Core.Application.Interfaces.Services
{
    public interface IRecordService : IGenericService<SaveRecord, ViewRecord, Record>
    {

    }
}