using api.Models;

namespace api.Seeders;

public class StockSeedersData
{
    public static List<Stock> GetData()
    {
        var stocks = new List<Stock>
        {
            new Stock
            {
                Id = 1,
                Symbol = "HAPV3",
                CompanyName = "Hapvida",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Saúde",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 2,
                Symbol = "B3SA3",
                CompanyName = "B3",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Mercado financeiro",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 3,
                Symbol = "CSAN3",
                CompanyName = "Cosan",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Etanol",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 4,
                Symbol = "LREN3",
                CompanyName = "Lojas Renner",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Vestuário",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 5,
                Symbol = "COGN3",
                CompanyName = "Cogna",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Educação",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 6,
                Symbol = "AZEV4",
                CompanyName = "Azevedo & Travassos",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Construção",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 7,
                Symbol = "MGLU3",
                CompanyName = "Magazine Luiza",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Varejo",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 8,
                Symbol = "BBDC4",
                CompanyName = "Banco Bradesco",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Banco",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 9,
                Symbol = "ABEV3",
                CompanyName = "Ambev",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Bebidas",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 10,
                Symbol = "BBAS3",
                CompanyName = "Banco do Brasil",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Banco",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 11,
                Symbol = "PETR4",
                CompanyName = "Petrobras",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Combustíveis",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 12,
                Symbol = "AZUL4",
                CompanyName = "Azul",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Companhias aéreas",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 13,
                Symbol = "ITUB4",
                CompanyName = "Itaú Unibanco",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Banco",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 14,
                Symbol = "ITSA4",
                CompanyName = "Itaúsa",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Holding",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
            new Stock
            {
                Id = 15,
                Symbol = "CVCB3",
                CompanyName = "CVC",
                Purchase = 1,
                LastDiv = 2,
                Industry = "Turismo",
                MarketCap = 3,
                CreatedAt = DateTime.Now
            },
        };

        return stocks;
    }
}
