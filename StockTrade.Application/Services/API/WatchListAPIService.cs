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

        public async Task<Summary> OnPostGetUserWishSymbolInfo(string wishSymbol)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-summary?symbol={wishSymbol}&region=US"),
                Headers =
                {
                    { "X-RapidAPI-Key", "b1bb396e5bmsh9fc9af5bff9a1a9p1f17fcjsn6ac532671e3b" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                Summary result = JsonSerializer.Deserialize<Summary>(data);

                return result;
            }
        }


    }
}
