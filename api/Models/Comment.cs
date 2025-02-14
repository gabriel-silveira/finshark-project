namespace api.Models
{
    public class Comment
    {
        public int id { get; set; }

        public string Title { get; set; } = string.Empty;
        
        public string Content { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public int? StockId { get; set; }

        // this is called Navigation property!
        public Stock? Stock { get; set; }
    }
}
