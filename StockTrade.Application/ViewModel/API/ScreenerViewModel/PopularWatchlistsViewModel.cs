using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.Screener.Portfolio
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class BackgroundImage
    {
        [JsonPropertyName("ios:sizesmall")]
        public IosSizesmall iossizesmall { get; set; }

        [JsonPropertyName("ios:sizecard_small_fixed")]
        public IosSizecardSmallFixed iossizecard_small_fixed { get; set; }

        [JsonPropertyName("ios:sizeextra_large")]
        public IosSizeextraLarge iossizeextra_large { get; set; }

        [JsonPropertyName("ios:sizeipad_portrait_retina")]
        public IosSizeipadPortraitRetina iossizeipad_portrait_retina { get; set; }

        [JsonPropertyName("ios:sizeipad_portrait")]
        public IosSizeipadPortrait iossizeipad_portrait { get; set; }

        [JsonPropertyName("ios:sizesquare_large")]
        public IosSizesquareLarge iossizesquare_large { get; set; }

        [JsonPropertyName("ios:sizemedium")]
        public IosSizemedium iossizemedium { get; set; }

        [JsonPropertyName("ios:sizelarge_new_fixed")]
        public IosSizelargeNewFixed iossizelarge_new_fixed { get; set; }

        [JsonPropertyName("ios:sizecard_large_fixed")]
        public IosSizecardLargeFixed iossizecard_large_fixed { get; set; }
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

    public class Finance
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; }

        [JsonPropertyName("error")]
        public object error { get; set; }
    }

    public class IosSizecardLargeFixed
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizecardSmallFixed
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizeextraLarge
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizeipadPortrait
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizeipadPortraitRetina
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizelargeNewFixed
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizemedium
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizesmall
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class IosSizesquareLarge
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("width")]
        public int width { get; set; }

        [JsonPropertyName("height")]
        public int height { get; set; }
    }

    public class OtherSortOption
    {
        [JsonPropertyName("sortField")]
        public string sortField { get; set; }

        [JsonPropertyName("sortOrder")]
        public object sortOrder { get; set; }

        [JsonPropertyName("sortTitle")]
        public string sortTitle { get; set; }
    }

    public class Portfolio
    {
        [JsonPropertyName("userId")]
        public string userId { get; set; }

        [JsonPropertyName("pfId")]
        public string pfId { get; set; }

        [JsonPropertyName("slug")]
        public string slug { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("shortDescription")]
        public string shortDescription { get; set; }

        [JsonPropertyName("symbolCount")]
        public int symbolCount { get; set; }

        [JsonPropertyName("followerCount")]
        public int followerCount { get; set; }

        [JsonPropertyName("brand")]
        public Brand brand { get; set; }

        [JsonPropertyName("createdAt")]
        public object createdAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public object updatedAt { get; set; }

        [JsonPropertyName("originalImageURL")]
        public string originalImageURL { get; set; }

        [JsonPropertyName("dailyPercentGain")]
        public double dailyPercentGain { get; set; }

        [JsonPropertyName("backgroundImage")]
        public BackgroundImage backgroundImage { get; set; }

        [JsonPropertyName("isFollowed")]
        public bool isFollowed { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("total")]
        public int total { get; set; }

        [JsonPropertyName("portfolios")]
        public List<Portfolio> portfolios { get; set; }

        [JsonPropertyName("selectedSortOption")]
        public SelectedSortOption selectedSortOption { get; set; }

        [JsonPropertyName("otherSortOptions")]
        public List<OtherSortOption> otherSortOptions { get; set; }
    }

    public class PopularWatchlists
    {
        [JsonPropertyName("finance")]
        public Finance finance { get; set; }
    }

    public class SelectedSortOption
    {
        [JsonPropertyName("sortField")]
        public string sortField { get; set; }

        [JsonPropertyName("sortOrder")]
        public string sortOrder { get; set; }

        [JsonPropertyName("sortTitle")]
        public string sortTitle { get; set; }
    }


}
