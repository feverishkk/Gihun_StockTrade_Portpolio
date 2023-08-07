using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ALLY
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class BAC
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class BackgroundImages
    {
        [JsonPropertyName("header")]
        public Header header { get; set; }

        [JsonPropertyName("hero")]
        public Hero hero { get; set; }

        [JsonPropertyName("card")]
        public Card card { get; set; }
    }

    public class Brand
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("displayName")]
        public string displayName { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("slug")]
        public string slug { get; set; }

        [JsonPropertyName("logoUrl")]
        public string logoUrl { get; set; }
    }

    public class Card
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public double width { get; set; }

        [JsonPropertyName("height")]
        public double height { get; set; }
    }

    public class CashPerformanceSettings
    {
        [JsonPropertyName("mode")]
        public string mode { get; set; }
    }

    public class COF
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class CVX
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class DVA
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Finance
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; }

        [JsonPropertyName("error")]
        public object error { get; set; }
    }

    public class FND
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class GM
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Header
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public double width { get; set; }

        [JsonPropertyName("height")]
        public double height { get; set; }
    }

    public class Hero
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public double width { get; set; }

        [JsonPropertyName("height")]
        public double height { get; set; }
    }

    public class HPQ
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class JEF
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class KO
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class KR
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Lot
    {
        [JsonPropertyName("lotId")]
        public string lotId { get; set; }

        [JsonPropertyName("sortOrder")]
        public double sortOrder { get; set; }

        [JsonPropertyName("tradeDate")]
        public string tradeDate { get; set; }

        [JsonPropertyName("purchasePrice")]
        public double purchasePrice { get; set; }

        [JsonPropertyName("quantity")]
        public double quantity { get; set; }
    }

    public class MCK
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class MCO
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("eventType")]
        public string eventType { get; set; }

        [JsonPropertyName("associatedSymbols")]
        public List<string> associatedSymbols { get; set; }
    }

    public class MKL
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class NU
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class OXY
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class PG
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Portfolio
    {
        [JsonPropertyName("userId")]
        public string userId { get; set; }

        [JsonPropertyName("pfId")]
        public string pfId { get; set; }

        [JsonPropertyName("pfType")]
        public string pfType { get; set; }

        [JsonPropertyName("pfVersionId")]
        public double pfVersionId { get; set; }

        [JsonPropertyName("sortOrder")]
        public double sortOrder { get; set; }

        [JsonPropertyName("pfName")]
        public string pfName { get; set; }

        [JsonPropertyName("baseCurrency")]
        public string baseCurrency { get; set; }

        [JsonPropertyName("slug")]
        public string slug { get; set; }

        [JsonPropertyName("cashCurrency")]
        public string cashCurrency { get; set; }

        [JsonPropertyName("consolidateLots")]
        public bool consolidateLots { get; set; }

        [JsonPropertyName("defaultPf")]
        public bool defaultPf { get; set; }

        [JsonPropertyName("following")]
        public bool following { get; set; }

        [JsonPropertyName("creationDate")]
        public long creationDate { get; set; }

        [JsonPropertyName("lastUpdated")]
        public long lastUpdated { get; set; }

        [JsonPropertyName("positions")]
        public List<Position> positions { get; set; }

        [JsonPropertyName("portfolioMeta")]
        public PortfolioMeta portfolioMeta { get; set; }

        [JsonPropertyName("cashPerformanceSettings")]
        public CashPerformanceSettings cashPerformanceSettings { get; set; }

        [JsonPropertyName("isMine")]
        public bool isMine { get; set; }

        [JsonPropertyName("betaPortfolio")]
        public bool betaPortfolio { get; set; }

        [JsonPropertyName("betaVersion")]
        public double betaVersion { get; set; }

        [JsonPropertyName("includeInTotalCalculation")]
        public bool includeInTotalCalculation { get; set; }

        [JsonPropertyName("positionCorporateActions")]
        public List<PositionCorporateAction> positionCorporateActions { get; set; }
    }

    public class PortfolioMeta
    {
        [JsonPropertyName("privacy")]
        public string privacy { get; set; }

        [JsonPropertyName("portfolioDescription")]
        public string portfolioDescription { get; set; }

        [JsonPropertyName("shortDescription")]
        public string shortDescription { get; set; }

        [JsonPropertyName("followerCount")]
        public double followerCount { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("shareUrl")]
        public string shareUrl { get; set; }

        [JsonPropertyName("backgroundImages")]
        public BackgroundImages backgroundImages { get; set; }

        [JsonPropertyName("brand")]
        public Brand brand { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("posId")]
        public string posId { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("sortOrder")]
        public double sortOrder { get; set; }

        [JsonPropertyName("lots")]
        public List<Lot> lots { get; set; }

        [JsonPropertyName("totalTransactionsCount")]
        public double totalTransactionsCount { get; set; }

        [JsonPropertyName("holdingsState")]
        public string holdingsState { get; set; }

        [JsonPropertyName("totalDividendTransactionsCount")]
        public double totalDividendTransactionsCount { get; set; }
    }

    public class PositionCorporateAction
    {
        [JsonPropertyName("header")]
        public string header { get; set; }

        [JsonPropertyName("message")]
        public string message { get; set; }

        [JsonPropertyName("meta")]
        public Meta meta { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("userId")]
        public string userId { get; set; }

        [JsonPropertyName("userIdType")]
        public string userIdType { get; set; }

        [JsonPropertyName("portfolios")]
        public List<Portfolio> portfolios { get; set; }

    }

    public class PopularWatchlistDetail
    {
        [JsonPropertyName("finance")]
        public Finance finance { get; set; }
    }

    public class SNOW
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class V
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("preMarketChange")]
        public double preMarketChange { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public double preMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public double preMarketPrice { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public double earningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public double earningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public double earningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class VTS
    {
        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("priceHint")]
        public double priceHint { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double regularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double regularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double bid { get; set; }

        [JsonPropertyName("ask")]
        public double ask { get; set; }

        [JsonPropertyName("bidSize")]
        public double bidSize { get; set; }

        [JsonPropertyName("askSize")]
        public double askSize { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public double averageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public double averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public double dividendDate { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double trailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double epsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double epsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double epsCurrentYear { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool esgPopulated { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double priceEpsCurrentYear { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public double sharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double bookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double fiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double fiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double twoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public double marketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double forwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double priceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public double sourceInterval { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public double gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double regularMarketChange { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double regularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double regularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public double regularMarketVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }


}
