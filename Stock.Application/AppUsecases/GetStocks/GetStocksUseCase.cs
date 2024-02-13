using Stock.Domain.DomainEntities;
using Stock.Domain.Interfaces;
using Stock.Domain.RepositoryContracts;


namespace Stock.Application.AppUsecases.GetStocks
{
    public class GetStocksUseCase
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetStocksUseCase(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }
        public StockDomain GetStockById(int id) 
        {
            return _unitOfWork.StockProductRepository.GetStockById(id);
        }
    }
}
