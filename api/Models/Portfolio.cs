using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public required string AppUserId { get; set; }
        
        public AppUser? AppUser { get; set; }
        
        public int StockId { get; set; }
        
        public Stock? Stock { get; set; }
    }
}
