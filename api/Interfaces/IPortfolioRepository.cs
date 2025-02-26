using api.Models;

namespace api.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>?> GetUserPortfolio(string username);
        
        Task<int?> AddStock(int stockId, string username);
    }
}
