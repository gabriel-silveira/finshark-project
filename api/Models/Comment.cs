using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("Comments")]
    public class Comment : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        
        public string Content { get; set; } = string.Empty;
        
        public int? StockId { get; set; }

        // this is called Navigation property!
        public Stock? Stock { get; set; }
    }
}
