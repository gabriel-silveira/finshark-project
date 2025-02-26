using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Comments")]
    public class Comment : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        
        public string Content { get; set; } = string.Empty;
        
        public int? StockId { get; set; }
        
        public Stock? Stock { get; set; }
        
        public string? AppUserId { get; set; }
        
        public AppUser? AppUser { get; set; }
    }
}
