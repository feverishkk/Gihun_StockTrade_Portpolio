using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.MarketViewModel;
using StockTrade.Application.ViewModel.API.StocksViewModel.StockChart;

namespace StockTrade.Application.Services.API
{
    public class StocksAPIService : IStocksAPIRepository
    {

        public StocksAPIService()
        {
            
        }

        public async Task<CompanyBrief> GetCompanyBrief( string symbol )
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-summary?symbol={ symbol }&region=US"),
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

                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<CompanyBrief>(data);

                if (result == null)
                {
                    return null;
                }

                return result;

            }
        }

        /// <summary>
        /// 범위: Max, 간격은 1d의 데이터를 가져온다.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public async Task<StockChart> GetStockChartMax( string symbol )
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v3/get-chart?interval=1d&symbol={ symbol }&range=max&region=US&includePrePost=false&useYfid=true&includeAdjustedClose=true&events=capitalGain%2Cdiv%2Csplit"),
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

                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<StockChart>(data);

                if (result == null)
                {
                    return null;
                }

                return result;
            }
        }



    }
}
