using api.Dtos.Stock;
using api.Filters.QueryObjects;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        List<StockDto> GetAllAsync(StockQueryObject stockQueryObject);
        
        Task<StockDto?> GetByIdAsync(int id);
        
        Task<Stock> CreateAsync(Stock stock);
        
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        
        Task<Stock?> DeleteAsync(int id);
        
        Task<bool> StockExists(int id);
    }
}
