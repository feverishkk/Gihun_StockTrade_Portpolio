using System.Text.Json.Serialization;

namespace StockTrade.Application.ViewModel.API.StocksViewModel.StockChart
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class _1662004800
    {
        [JsonPropertyName("date")]
        public long date { get; set; }

        [JsonPropertyName("numerator")]
        public long numerator { get; set; }

        [JsonPropertyName("denominator")]
        public long denominator { get; set; }

        [JsonPropertyName("splitRatio")]
        public string splitRatio { get; set; }
    }

    public class Adjclose
    {
        [JsonPropertyName("adjclose")]
        public List<double> adjclose { get; set; }
    }

    public class Chart
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; }

        [JsonPropertyName("error")]
        public object error { get; set; }
    }

    public class CurrentTradingPeriod
    {
        [JsonPropertyName("pre")]
        public Pre pre { get; set; }

        [JsonPropertyName("regular")]
        public Regular regular { get; set; }

        [JsonPropertyName("post")]
        public Post post { get; set; }
    }

    public class Events
    {
        [JsonPropertyName("splits")]
        public Splits splits { get; set; }
    }

    public class Indicators
    {
        [JsonPropertyName("quote")]
        public List<Quote> quote { get; set; }

        [JsonPropertyName("adjclose")]
        public List<Adjclose> adjclose { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("exchangeName")]
        public string exchangeName { get; set; }

        [JsonPropertyName("instrumentType")]
        public string instrumentType { get; set; }

        [JsonPropertyName("firstTradeDate")]
        public long firstTradeDate { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public long regularMarketTime { get; set; }

        [JsonPropertyName("gmtoffset")]
        public long gmtoffset { get; set; }

        [JsonPropertyName("timezone")]
        public string timezone { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("chartPreviousClose")]
        public double chartPreviousClose { get; set; }

        [JsonPropertyName("priceHint")]
        public long priceHint { get; set; }

        [JsonPropertyName("currentTradingPeriod")]
        public CurrentTradingPeriod currentTradingPeriod { get; set; }

        [JsonPropertyName("dataGranularity")]
        public string dataGranularity { get; set; }

        [JsonPropertyName("range")]
        public string range { get; set; }

        [JsonPropertyName("validRanges")]
        public List<string> validRanges { get; set; }
    }

    public class Post
    {
        [JsonPropertyName("timezone")]
        public string timezone { get; set; }

        [JsonPropertyName("start")]
        public long start { get; set; }

        [JsonPropertyName("end")]
        public long end { get; set; }

        [JsonPropertyName("gmtoffset")]
        public long gmtoffset { get; set; }
    }

    public class Pre
    {
        [JsonPropertyName("timezone")]
        public string timezone { get; set; }

        [JsonPropertyName("start")]
        public long start { get; set; }

        [JsonPropertyName("end")]
        public long end { get; set; }

        [JsonPropertyName("gmtoffset")]
        public long gmtoffset { get; set; }
    }

    public class Quote
    {
        [JsonPropertyName("high")]
        public List<double> high { get; set; }

        [JsonPropertyName("open")]
        public List<double> open { get; set; }

        [JsonPropertyName("close")]
        public List<double> close { get; set; }

        [JsonPropertyName("low")]
        public List<double> low { get; set; }

        [JsonPropertyName("volume")]
        public List<object> volume { get; set; }
    }

    public class Regular
    {
        [JsonPropertyName("timezone")]
        public string timezone { get; set; }

        [JsonPropertyName("start")]
        public long start { get; set; }

        [JsonPropertyName("end")]
        public long end { get; set; }

        [JsonPropertyName("gmtoffset")]
        public long gmtoffset { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("meta")]
        public Meta meta { get; set; }

        [JsonPropertyName("timestamp")]
        public List<string> timestamp { get; set; }

        [JsonPropertyName("events")]
        public Events events { get; set; }

        [JsonPropertyName("indicators")]
        public Indicators indicators { get; set; }
    }

    public class StockChart
    {
        [JsonPropertyName("chart")]
        public Chart chart { get; set; }
    }

    public class Splits
    {
        [JsonPropertyName("1662004800")]
        public _1662004800 _1662004800 { get; set; }
    }





}
