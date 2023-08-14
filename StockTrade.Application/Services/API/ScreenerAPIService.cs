using Newtonsoft.Json;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail;
using StockTrade.Application.ViewModel.API.Screener.Portfolio;
using StockTrade.Application.ViewModel.API.ScreenerViewModel.Performance;

namespace StockTrade.Application.Services.API
{
    public class ScreenerAPIService : IScreenerAPIRepository
    {
        public async Task<PopularWatchlistDetail> GetPopularWatchlistDetail( string pfId )
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/market/get-watchlist-detail?userId=X3NJ2A7VDSABUI4URBWME2PZNM&pfId={ pfId }"),
                Headers =
                {
                    { "X-RapidAPI-Key", "67299239f2msh92134da33510274p1b9b3djsne884838a4620" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<PopularWatchlistDetail>(data);

                return result;
            }
        }

        public async Task<Performance> GetPopularWatchlistPerformance( string pfId )
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/market/get-watchlist-performance?userId=X3NJ2A7VDSABUI4URBWME2PZNM&pfId={ pfId }&symbols=UPS&region=US"),
                Headers =
                {
                    { "X-RapidAPI-Key", "67299239f2msh92134da33510274p1b9b3djsne884838a4620" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<Performance>(data);

                return result;
            }
        }

        public async Task<PopularWatchlists> GetPopularWatchlists()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/market/get-popular-watchlists"),
                Headers =
                {
                    { "X-RapidAPI-Key", "67299239f2msh92134da33510274p1b9b3djsne884838a4620" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<PopularWatchlists>(data);

                return result;
            }
        }








    }
}
