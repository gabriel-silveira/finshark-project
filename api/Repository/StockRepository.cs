using api.Data;
using api.Dtos.Stock;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StockDto>> GetAllAsync()
        {
            var stocks = await _context.Stocks
                .Include(c => c.Comments)
                .ToListAsync();
            
            var stockDto = stocks.Select(s => s.ToStockDto());
            
            return stockDto;
        }

        public async Task<StockDto?> GetByIdAsync(int id)
        {
            var stock = await _context.Stocks
                .Include(c => c.Comments)
                .FirstOrDefaultAsync(i => i.Id == id);

            return stock?.ToStockDto() ?? null;
        }

        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await _context.Stocks.AddAsync(stockModel);
            
            await _context.SaveChangesAsync();

            return stockModel;
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto)
        {
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);

            if (stockModel == null) return null;
            
            stockModel.Symbol = stockDto.Symbol;
            stockModel.CompanyName = stockDto.CompanyName;
            stockModel.Purchase = stockDto.Purchase;
            stockModel.LastDiv = stockDto.LastDiv;
            stockModel.Industry = stockDto.Industry;
            stockModel.MarketCap = stockDto.MarketCap;
            
            await _context.SaveChangesAsync();
            
            return stockModel;
        }

        public async Task<Stock?> DeleteAsync(int id)
        {
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);

            if (stockModel == null) return null;

            _context.Stocks.Remove(stockModel);
            
            await _context.SaveChangesAsync();

            return stockModel;
        }

        public async Task<bool> StockExists(int id)
        {
            return await _context.Stocks.AnyAsync(s => s.Id == id);
        }
    }
}
