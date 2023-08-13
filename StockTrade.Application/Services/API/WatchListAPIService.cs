using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.WatchList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockTrade.Application.Services.API
{
    public class WatchListAPIService : IWatchListAPIRepository
    {

        public async Task<WatchList> OnPostGetUserWishSymbolInfo(string wishSymbol)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-summary?symbol={wishSymbol}&region=US"),
                Headers =
                {
                    { "X-RapidAPI-Key", "e0092d0980msh7378f57b2934926p1f9726jsn298f6e64a622" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                WatchList result = JsonSerializer.Deserialize<WatchList>(data);

                return result;
            }
        }


    }
}
