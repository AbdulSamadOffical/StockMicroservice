using AutoMapper;
using Stock.Application.AppUsecases.GetStocks;
using Stock.Domain.Entities;
using Stock.Domain.DomainEntities;


namespace Stock.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile() 
        {

            CreateMap<StockProduct, StockDomain>();
        }

    }
}
