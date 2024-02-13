using Stock.Domain.DomainEntities;


namespace Stock.Domain.RepositoryContracts
{
    public interface IStockProductRepository
    {
        public StockDomain GetStockById(int id);
    }
}
