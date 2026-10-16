using AutoMapper;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Application.Interfaces.Repositories;
using LoansApp.Core.Application.Interfaces.Services;
using LoansApp.Core.Domain.Entities;

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
    }
}
