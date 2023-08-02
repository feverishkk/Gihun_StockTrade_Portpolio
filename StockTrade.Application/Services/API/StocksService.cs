using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.Interfaces.API;

namespace StockTrade.Application.Services.API
{
    public class StocksService : IStocksRepository
    {

        public StocksService()
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
                    { "X-RapidAPI-Key", "c1b44bd912msh2f07e988adef1aap16ae60jsnac03fd75789e" },
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








    }
}
