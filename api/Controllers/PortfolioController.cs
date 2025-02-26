using api.Extensions;
using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class PortfolioController(IPortfolioRepository portfolioRepository) : Controller
    {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserPortfolio()
        {
            var userPortfolio = await portfolioRepository.GetUserPortfolio(User.GetUsername());

            return userPortfolio == null ? BadRequest("Couldn't get the user portfolio") : Ok(userPortfolio);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddStockToPortfolio([FromBody] int stockId)
        {
            var stockAdded = await portfolioRepository.AddStock(stockId, User.GetUsername());

            return stockAdded == null ? BadRequest("Couldn't add the stock to the portfolio") : Ok(stockAdded);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> RemoveStockFromPortfolio([FromBody] int stockId)
        {
            var removedId = await portfolioRepository.RemoveStock(stockId, User.GetUsername());
            
            return removedId != null ? Ok(removedId) : BadRequest("Couldn't remove the stock from the portfolio");
        }
    }
}
