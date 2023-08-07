using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.ScreenerViewModel.Performance
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Finance
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; }

        [JsonPropertyName("error")]
        public object error { get; set; }
    }

    public class UPS
    {
        [JsonPropertyName("oneDayPercentChange")]
        public double oneDayPercentChange { get; set; }

        [JsonPropertyName("oneMonthPercentChange")]
        public double oneMonthPercentChange { get; set; }

        [JsonPropertyName("oneYearPercentChange")]
        public double oneYearPercentChange { get; set; }

        [JsonPropertyName("lifetimePercentChange")]
        public double lifetimePercentChange { get; set; }

        [JsonPropertyName("originTimestamp")]
        public int originTimestamp { get; set; }

        [JsonPropertyName("updatedAt")]
        public int updatedAt { get; set; }
    }

    public class Portfolio
    {
        [JsonPropertyName("oneDayPercentChange")]
        public double oneDayPercentChange { get; set; }

        [JsonPropertyName("oneMonthPercentChange")]
        public double oneMonthPercentChange { get; set; }

        [JsonPropertyName("oneYearPercentChange")]
        public double oneYearPercentChange { get; set; }

        [JsonPropertyName("lifetimePercentChange")]
        public double lifetimePercentChange { get; set; }

        [JsonPropertyName("originTimestamp")]
        public int originTimestamp { get; set; }

        [JsonPropertyName("updatedAt")]
        public int updatedAt { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("portfolio")]
        public Portfolio portfolio { get; set; }

        [JsonPropertyName("symbols")]
        public Symbols symbols { get; set; }
    }

    public class Performance
    {
        [JsonPropertyName("finance")]
        public Finance finance { get; set; }
    }

    public class Symbols
    {
        [JsonPropertyName("^GSPC")]
        public UPS UPS { get; set; }
    }


}
