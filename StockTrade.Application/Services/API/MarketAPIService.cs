using Newtonsoft.Json;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.MarketViewModel;
using StockTrade.Application.ViewModel.API.MarketViewModel.Crypto;
using System.Net.Http.Headers;

namespace StockTrade.Application.Services.API
{
    public class MarketAPIService : IMarketAPIRepository
    {

        public MarketAPIService()
        {
            
        }

        public async Task<Crypto> GetCrypto()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/screeners/get-symbols-by-predefined?scrIds=all_cryptocurrencies_us&start=0&count=50"),
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

                var result = JsonConvert.DeserializeObject<Crypto>( data );

                return result;
            }
        }

        public async Task<MarketNews> GetMarketNews()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/news/v2/list?region=US&snippetCount=8"),
                Headers =
                {
                    { "X-RapidAPI-Key", "67299239f2msh92134da33510274p1b9b3djsne884838a4620" },
                    { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
                Content = new StringContent("Pass in the value of uuids field returned right in this endpoint to load the next page, or leave empty to load first page")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("text/plain")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<MarketNews>(data);

                return result;
            }
        }






    }
}
