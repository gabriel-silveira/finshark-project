using api.Mappers;
using api.Dtos.Stock;
using api.Filters.QueryObjects;
using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers {
    [Route("/api/stock")]
    [ApiController]
    public class StockController(IStockRepository stockRepository) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetAll([FromQuery] StockQueryObject stockQueryObject)
        {
            var stocks = stockRepository.GetAllAsync(stockQueryObject);

            return Ok(stocks);
        }

        [HttpGet("{id:int}")]
        [Authorize]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await stockRepository.GetByIdAsync(id);
            
            return stock == null ? NotFound("Stock not found") : Ok(stock);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] CreateStockRequestDto stockDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var stockModel = stockDto.ToStockFromCreateDto();
            
            await stockRepository.CreateAsync(stockModel);
            
            return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel);
        }

        [HttpPut("{id:int}")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDto stockDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var stockModel = await stockRepository.UpdateAsync(id, stockDto);
            
            return stockModel == null ? NotFound("Stock not found") : Ok(stockModel);
        }

        [HttpDelete("{id:int}")]
        [Authorize]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var stockModel = await stockRepository.DeleteAsync(id);

            return stockModel == null ? NotFound("Stock not found") : NoContent();
        }
    }
}
