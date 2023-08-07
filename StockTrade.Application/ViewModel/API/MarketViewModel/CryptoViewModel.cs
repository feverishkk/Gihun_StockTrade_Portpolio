using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.MarketViewModel.Crypto
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AverageDailyVolume10Day
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class AverageDailyVolume3Month
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class CirculatingSupply
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class CriteriaMeta
    {
        [JsonPropertyName("size")]
        public int size { get; set; }

        [JsonPropertyName("offset")]
        public int offset { get; set; }

        [JsonPropertyName("sortField")]
        public string sortField { get; set; }

        [JsonPropertyName("sortType")]
        public string sortType { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("criteria")]
        public List<Criterion> criteria { get; set; }

        [JsonPropertyName("topOperator")]
        public string topOperator { get; set; }
    }

    public class Criterion
    {
        [JsonPropertyName("field")]
        public string field { get; set; }

        [JsonPropertyName("operators")]
        public List<string> operators { get; set; }

        [JsonPropertyName("values")]
        public List<string> values { get; set; }

        [JsonPropertyName("labelsSelected")]
        public List<object> labelsSelected { get; set; }

        [JsonPropertyName("dependentValues")]
        public List<object> dependentValues { get; set; }
    }

    public class FiftyDayAverage
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyDayAverageChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyDayAverageChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekHighChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekHighChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLowChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLowChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekRange
    {
        [JsonPropertyName("raw")]
        public string raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Finance
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; }

        [JsonPropertyName("error")]
        public object error { get; set; }
    }

    public class MarketCap
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Quote
    {
        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public TwoHundredDayAverageChangePercent twoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public FiftyTwoWeekLowChangePercent fiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupply circulatingSupply { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public RegularMarketDayRange regularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public TwoHundredDayAverageChange twoHundredDayAverageChange { get; set; }

        [JsonPropertyName("fromCurrency")]
        public string fromCurrency { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public TwoHundredDayAverage twoHundredDayAverage { get; set; }

        [JsonPropertyName("marketCap")]
        public MarketCap marketCap { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public FiftyTwoWeekHighChange fiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public FiftyTwoWeekRange fiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public FiftyDayAverageChange fiftyDayAverageChange { get; set; }

        [JsonPropertyName("lastMarket")]
        public string lastMarket { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public AverageDailyVolume3Month averageDailyVolume3Month { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public int exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("firstTradeDateMilliseconds")]
        public object firstTradeDateMilliseconds { get; set; }

        [JsonPropertyName("fiftyTwoWeekChangePercent")]
        public FiftyTwoWeekChangePercent fiftyTwoWeekChangePercent { get; set; }

        [JsonPropertyName("logoUrl")]
        public string logoUrl { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public FiftyTwoWeekLow fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public RegularMarketVolume regularMarketVolume { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("toCurrency")]
        public string toCurrency { get; set; }

        [JsonPropertyName("priceHint")]
        public int priceHint { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public RegularMarketDayLow regularMarketDayLow { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("sourceInterval")]
        public int sourceInterval { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public FiftyDayAverageChangePercent fiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("startDate")]
        public StartDate startDate { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string fullExchangeName { get; set; }

        [JsonPropertyName("coinImageUrl")]
        public string coinImageUrl { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public int gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public RegularMarketOpen regularMarketOpen { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public RegularMarketTime regularMarketTime { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public RegularMarketChangePercent regularMarketChangePercent { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public AverageDailyVolume10Day averageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public FiftyTwoWeekLowChange fiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public FiftyTwoWeekHighChangePercent fiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("typeDisp")]
        public string typeDisp { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public FiftyTwoWeekHigh fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24Hr volume24Hr { get; set; }

        [JsonPropertyName("coinMarketCapLink")]
        public string coinMarketCapLink { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public RegularMarketChange regularMarketChange { get; set; }

        [JsonPropertyName("cryptoTradeable")]
        public bool cryptoTradeable { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrencies volumeAllCurrencies { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public FiftyDayAverage fiftyDayAverage { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public RegularMarketPrice regularMarketPrice { get; set; }

        [JsonPropertyName("customPriceAlertConfidence")]
        public string customPriceAlertConfidence { get; set; }

        [JsonPropertyName("triggerable")]
        public bool triggerable { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }
    }

    public class RegularMarketChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketDayHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketDayLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketDayRange
    {
        [JsonPropertyName("raw")]
        public string raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketOpen
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketPreviousClose
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketTime
    {
        [JsonPropertyName("raw")]
        public int raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketVolume
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("canonicalName")]
        public string canonicalName { get; set; }

        [JsonPropertyName("criteriaMeta")]
        public CriteriaMeta criteriaMeta { get; set; }

        [JsonPropertyName("rawCriteria")]
        public string rawCriteria { get; set; }

        [JsonPropertyName("start")]
        public int start { get; set; }

        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("total")]
        public int total { get; set; }

        [JsonPropertyName("quotes")]
        public List<Quote> quotes { get; set; }

        [JsonPropertyName("useRecords")]
        public bool useRecords { get; set; }

        [JsonPropertyName("predefinedScr")]
        public bool predefinedScr { get; set; }

        [JsonPropertyName("versionId")]
        public int versionId { get; set; }

        [JsonPropertyName("creationDate")]
        public long creationDate { get; set; }

        [JsonPropertyName("lastUpdated")]
        public long lastUpdated { get; set; }

        [JsonPropertyName("isPremium")]
        public bool isPremium { get; set; }

        [JsonPropertyName("iconUrl")]
        public string iconUrl { get; set; }
    }

    public class Crypto
    {
        [JsonPropertyName("finance")]
        public Finance finance { get; set; }
    }

    public class StartDate
    {
        [JsonPropertyName("raw")]
        public int raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class TwoHundredDayAverage
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TwoHundredDayAverageChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TwoHundredDayAverageChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Volume24Hr
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class VolumeAllCurrencies
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }


}
