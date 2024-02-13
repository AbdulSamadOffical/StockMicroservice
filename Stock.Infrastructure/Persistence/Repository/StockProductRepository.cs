using Stock.Domain.Entities;
using Stock.Domain.RepositoryContracts;
using AutoMapper;
using Stock.Domain.DomainEntities;

namespace Stock.Infrastructure.Persistence.Repository
{
    public class StockProductRepository : IStockProductRepository
    {
        private readonly IMapper _mapper;
        protected readonly ApplicationContext _context;
        private readonly IGenericRepository<StockProduct> _stockProduct;
        public StockProductRepository(IMapper mapper, ApplicationContext context, IGenericRepository<StockProduct> stockProduct)
        {
            _context = context;
            _stockProduct = stockProduct;
            _mapper = mapper;
        }

        public StockDomain GetStockById(int id)
        {
            var stockProduct = _stockProduct.GetById(id);
            var stock = _mapper.Map<StockDomain>(stockProduct);
            return stock;
        }
    }
}
