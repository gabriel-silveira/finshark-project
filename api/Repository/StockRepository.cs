using api.Data;
using api.Dtos.Stock;
using api.Filters.QueryObjects;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository(ApplicationDbContext context) : IStockRepository
    {
        public List<StockDto> GetAllAsync(StockQueryObject stockQueryObject)
        {
            var stocks = context.Stocks
                .Include(c => c.Comments)
                .ThenInclude(c => c.AppUser)
                .AsQueryable();

            if (stockQueryObject.Id != null)
            {
                stocks = stocks.Where(stock => stock.Id == stockQueryObject.Id);
            }

            if (!string.IsNullOrWhiteSpace(stockQueryObject.Symbol))
            {
                stocks = stocks.Where(stock => stock.Symbol.Contains(stockQueryObject.Symbol));
            }

            if (!string.IsNullOrWhiteSpace(stockQueryObject.CompanyName))
            {
                stocks = stocks.Where(stock => stock.CompanyName.Contains(stockQueryObject.CompanyName));
            }

            // TODO: move this code to another filtering class
            if (!string.IsNullOrWhiteSpace(stockQueryObject.SortBy))
            {
                if (stockQueryObject.SortBy.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    stocks = stockQueryObject.IsDescending ?
                        stocks.OrderByDescending(s => s.Id) : stocks.OrderBy(s => s.Id);
                }
            } else if (!string.IsNullOrWhiteSpace(stockQueryObject.SortBy))
            {
                if (stockQueryObject.SortBy.Equals("Symbol", StringComparison.OrdinalIgnoreCase))
                {
                    stocks = stockQueryObject.IsDescending ?
                        stocks.OrderByDescending(s => s.Symbol) : stocks.OrderBy(s => s.Symbol);
                }
            } else if (!string.IsNullOrWhiteSpace(stockQueryObject.SortBy))
            {
                if (stockQueryObject.SortBy.Equals("CompanyName", StringComparison.OrdinalIgnoreCase))
                {
                    stocks = stockQueryObject.IsDescending ?
                        stocks.OrderByDescending(s => s.CompanyName) : stocks.OrderBy(s => s.CompanyName);
                }
            }
            // END_TODO
            
            var skipNumber = (stockQueryObject.PageNumber - 1) * stockQueryObject.PageSize;
            
            var stockDto = stocks.Skip(skipNumber).Take(stockQueryObject.PageSize).Select(s => s.ToStockDto());
            
            return stockDto.ToList();
        }

        public async Task<StockDto?> GetByIdAsync(int id)
        {
            var stock = await context.Stocks
                .Include(c => c.Comments)
                .FirstOrDefaultAsync(i => i.Id == id);

            return stock?.ToStockDto() ?? null;
        }

        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await context.Stocks.AddAsync(stockModel);
            
            await context.SaveChangesAsync();

            return stockModel;
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var stockModel = await context.Stocks.FirstOrDefaultAsync(s => s.Id == id);

            if (stockModel == null) return null;
            
            stockModel.Symbol = stockDto.Symbol;
            stockModel.CompanyName = stockDto.CompanyName;
            stockModel.Purchase = stockDto.Purchase;
            stockModel.LastDiv = stockDto.LastDiv;
            stockModel.Industry = stockDto.Industry;
            stockModel.MarketCap = stockDto.MarketCap;
            
            await context.SaveChangesAsync();
            
            return stockModel;
        }

        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockModel = await context.Stocks.FirstOrDefaultAsync(s => s.Id == id);

            if (stockModel == null) return null;

            context.Stocks.Remove(stockModel);
            
            await context.SaveChangesAsync();

            return stockModel;
        }

        public async Task<bool> StockExists(int id)
        {
            return await context.Stocks.AnyAsync(s => s.Id == id);
        }
    }
}
