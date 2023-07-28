using System.Text.Json.Serialization;

namespace StockProject.Infrastructure.Shared
{
    public class StockSymbol
    {
        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; } = string.Empty;

        [JsonPropertyName("Symbol")]
        public string Symbol { get; set; } = string.Empty;
    }
}