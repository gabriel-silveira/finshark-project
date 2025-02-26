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

            return userPortfolio == null ? BadRequest("Can't get the user portfolio") : Ok(userPortfolio);
        }
    }
}
