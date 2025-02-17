using api.Data;
using api.Mappers;
using api.DTOs.Stock;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers {
    [Route("/api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // .ToList() is a "deferred execution"
            var stocks = _context.Stocks.ToList().Select(s => s.ToStockDTO());

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);

            if (stock == null)
            {
                return NotFound();
            }
            
            return Ok(stock.ToStockDTO());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateStockRequestDTO stockDto)
        {
            var stockModel = stockDto.ToStockFromCreateDTO();

            _context.Stocks.Add(stockModel);
            
            _context.SaveChanges();
            
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel);
        }
    }
}
