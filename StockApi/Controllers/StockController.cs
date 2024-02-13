using Microsoft.AspNetCore.Mvc;
using Stock.Application.AppUsecases.GetStocks;


namespace StockApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
       
        private readonly ILogger<StockController> _logger;
        private readonly GetStocksUseCase _getStocksUseCase;

        public StockController(ILogger<StockController> logger, GetStocksUseCase getStocksUseCase)
        {
            _logger = logger;
            _getStocksUseCase = getStocksUseCase;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var stockDomain = _getStocksUseCase.GetStockById(id);
            if (stockDomain == null)
            {
                return NotFound(); 
            }

           
            return Ok(stockDomain); 
        }
    }
}
