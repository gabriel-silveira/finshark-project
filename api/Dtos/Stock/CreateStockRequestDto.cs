using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be longer than 10 characters.")]
        public string Symbol { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50, ErrorMessage = "Company name cannot be longer than 50 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        
        [Required]
        [Range(0.001, 1000000000, ErrorMessage = "Purchase must be between 0.001 and 10000000.")]
        public decimal Purchase { get; set; }
        
        [Required]
        [Range(0.001, 100, ErrorMessage = "Last dividend must be between 0.001 and 100.")]
        public decimal LastDiv { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Industry cannot be longer than 50 characters.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000, ErrorMessage = "Market cap must be between 1 and 5000000000.")]
        public long MarketCap { get; set; }
    }
}
