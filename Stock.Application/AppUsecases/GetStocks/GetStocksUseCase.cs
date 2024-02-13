using Stock.Domain.DomainEntities;
using Stock.Domain.RepositoryContracts;


namespace Stock.Application.AppUsecases.GetStocks
{
    public class GetStocksUseCase
    {

        private readonly IStockProductRepository _productRepository;

        public GetStocksUseCase(IStockProductRepository productRepository) {
            _productRepository = productRepository;
        }
        public StockDomain GetStockById(int id) 
        {
            return _productRepository.GetStockById(id);
        }
    }
}
