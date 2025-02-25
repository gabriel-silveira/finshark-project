namespace api.Filters.QueryObjects
{
    public class StockQueryObject : BaseQueryObject
    {
        public int? Id { get; set; }

        public string? Symbol { get; set; } = null;
        
        public string? CompanyName { get; set; } = null;
    }
}
