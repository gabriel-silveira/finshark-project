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

            return appUser != null
                ? await context.Portfolios
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
                    }).ToListAsync()
                : null;
        }

        public async Task<int?> AddStock(int stockId, string username)
        {
            var appUser = await userManager.FindByNameAsync(username);

            if (appUser == null) return null;

            var portfolioItemExists = await context.Portfolios.AnyAsync(
                portfolio => portfolio.AppUserId == appUser.Id && portfolio.StockId == stockId
            );

            if (portfolioItemExists) return null;

            await context.Portfolios.AddAsync(new Portfolio { AppUserId = appUser.Id, StockId = stockId });

            await context.SaveChangesAsync();

            return stockId;
        }

        public async Task<int?> RemoveStock(int stockId, string username)
        {
            var appUser = await userManager.FindByNameAsync(username);

            if (appUser == null) return null;

            var currentPortfolioItem = await context.Portfolios.FirstOrDefaultAsync(
                portfolio => portfolio.AppUserId == appUser.Id && portfolio.StockId == stockId
            );

            if (currentPortfolioItem == null) return null;

            context.Portfolios.Remove(currentPortfolioItem);
            
            await context.SaveChangesAsync();

            return stockId;
        }
    }
}
