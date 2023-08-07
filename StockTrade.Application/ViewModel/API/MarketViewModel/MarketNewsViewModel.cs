using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.MarketViewModel
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ClickThroughUrl
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Content
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("contentType")]
        public string contentType { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("pubDate")]
        public DateTime pubDate { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail thumbnail { get; set; }

        [JsonPropertyName("clickThroughUrl")]
        public ClickThroughUrl clickThroughUrl { get; set; }

        [JsonPropertyName("previewUrl")]
        public string previewUrl { get; set; }

        [JsonPropertyName("provider")]
        public Provider provider { get; set; }

        [JsonPropertyName("finance")]
        public Finance finance { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("ntk")]
        public Ntk ntk { get; set; }

        [JsonPropertyName("main")]
        public Main main { get; set; }
    }

    public class Finance
    {
        [JsonPropertyName("stockTickers")]
        public List<StockTicker> stockTickers { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("stream")]
        public List<Stream> stream { get; set; }

        [JsonPropertyName("nextPage")]
        public bool nextPage { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination pagination { get; set; }
    }

    public class Ntk
    {
        [JsonPropertyName("stream")]
        public List<object> stream { get; set; }

        [JsonPropertyName("nextPage")]
        public bool nextPage { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("uuids")]
        public string uuids { get; set; }
    }

    public class Provider
    {
        [JsonPropertyName("displayName")]
        public string displayName { get; set; }
    }

    public class Resolution
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }

        [JsonPropertyName("tag")]
        public string tag { get; set; }
    }

    public class MarketNews
    {
        [JsonPropertyName("data")]
        public Data data { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }
    }

    public class StockTicker
    {
        [JsonPropertyName("symbol")]
        public string symbol { get; set; }
    }

    public class Stream
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("content")]
        public Content content { get; set; }
    }

    public class Thumbnail
    {
        [JsonPropertyName("resolutions")]
        public List<Resolution> resolutions { get; set; }
    }


}
