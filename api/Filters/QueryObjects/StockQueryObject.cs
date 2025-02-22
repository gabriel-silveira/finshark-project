namespace api.Filters.QueryObjects
{
    public class StockQueryObject
    {
        public int? Id { get; set; }

        public string? Symbol { get; set; } = null;
        
        public string? CompanyName { get; set; } = null;
        
        public string? SortBy { get; set; } = null;
        
        public bool IsDescending { get; set; } = false;
    }
}
