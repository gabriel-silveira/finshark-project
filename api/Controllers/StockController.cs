using api.Data;
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
            var stocks = _context.Stocks.ToList();

            return Ok(stocks);
        }

        [HttpPost("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);

            if (stock == null)
            {
                return NotFound();
            }
            
            return Ok(stock);
        }
    }
}
