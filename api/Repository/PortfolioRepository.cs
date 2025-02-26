using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class PortfolioRepository(
        ApplicationDbContext context,
        UserManager<AppUser> userManager
    ) : IPortfolioRepository
    {
        public async Task<List<Stock>?> GetUserPortfolio(string username)
        {
            var appUser = await userManager.FindByNameAsync(username);

            if (appUser == null) return null;

            return await context.Portfolios
                .Where(portfolio => portfolio.AppUserId == appUser.Id)
                .Select(portfolio => new Stock
                {
                    Id = portfolio.StockId,
                    Symbol = portfolio.Stock.Symbol,
                    CompanyName = portfolio.Stock.CompanyName,
                    Purchase = portfolio.Stock.Purchase,
                    LastDiv = portfolio.Stock.LastDiv,
                    Industry = portfolio.Stock.Industry,
                    MarketCap = portfolio.Stock.MarketCap,
                }).ToListAsync();
        }
    }
}
