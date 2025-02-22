using api.Mappers;
using api.Dtos.Stock;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers {
    [Route("/api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        
        public StockController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stocks = await _stockRepository.GetAllAsync();

            return Ok(stocks);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _stockRepository.GetByIdAsync(id);

            if (stock == null) return NotFound();
            
            return Ok(stock);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStockRequestDto stockDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var stockModel = stockDto.ToStockFromCreateDto();
            
            await _stockRepository.CreateAsync(stockModel);
            
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDto stockDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var stockModel = await _stockRepository.UpdateAsync(id, stockDto);
            
            if (stockModel == null) return NotFound();
            
            return Ok(stockModel);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var stockModel = await _stockRepository.DeleteAsync(id);
            
            if (stockModel == null) return NotFound();

            return NoContent();
        }
    }
}
