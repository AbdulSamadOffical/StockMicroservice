using Stock.Domain.Entities;
using Stock.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infrastructure.Persistence.Repository
{
    public class StockProductRepository : IStockProductRepository
    {
        protected readonly ApplicationContext _context;
        public StockProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public StockProduct getMaxStockProductByPrice()
        {
            throw new NotImplementedException();
        }
    }
}
