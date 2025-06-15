using AutoMapper;
using LoansApp.Core.Application.DTOs.Loan;
using LoansApp.Core.Application.DTOs.Payment;
using LoansApp.Core.Application.DTOs.Record;
using LoansApp.Core.Domain.Entities;

namespace LoansApp.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Loan, SaveLoan>()
                .ReverseMap()
                .ForMember(dest => dest.Payments, opt => opt.Ignore());

            CreateMap<Loan, ViewLoan>()
                .ReverseMap()
                .ForMember(dest => dest.Payments, opt => opt.Ignore());

            CreateMap<SaveLoan, ViewLoan>()
                .ReverseMap();

            CreateMap<Payment, SavePayment>()
                .ReverseMap()
                .ForMember(dest => dest.Loan, opt => opt.Ignore());

            CreateMap<Payment, ViewPayment>()
                .ReverseMap();

            CreateMap<Record, SaveRecord>()
                .ReverseMap();
            
            CreateMap<Record, ViewRecord>()
                .ReverseMap();

        }
    }
}
