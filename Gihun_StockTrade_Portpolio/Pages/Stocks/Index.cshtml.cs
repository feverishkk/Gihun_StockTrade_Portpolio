using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.StocksViewModel.ChartEntities;
using StockTrade.Application.ViewModel.API.StocksViewModel.StockChart;
using StockProject.Infrastructure.Shared;

namespace Gihun_StockTrade_Portpolio.Pages.Stocks
{
    public class IndexModel : PageModel
    {
        private readonly IStocksAPIRepository _stocksAPIRepository;

        public List<StockChartViewModel> StockChartResult { get; set; }

        public IndexModel( IStocksAPIRepository stocksAPIRepository )
        {
            _stocksAPIRepository = stocksAPIRepository; 
        }

        public void OnGet()
        {
        }


        public void OnPost() 
        {
            
        }
        public async Task OnPostGetStockChart( string symbol )
        {
            // 범위: Max, 간격은 1d의 데이터를 가져온다.
            var data = await _stocksAPIRepository.GetStockChartMax( symbol );

            if (data == null)
            {
                //return null;
                return;
            }

            List<Result> result = data.chart.result;

            var open = result[0]?.indicators?.quote[0]?.open?.ToList();
            var close = result[0]?.indicators?.quote[0]?.close?.ToList();
            var high = result[0]?.indicators?.quote[0]?.high?.ToList();
            var low = result[0]?.indicators?.quote[0]?.low?.ToList();
            var vol = result[0]?.indicators?.quote[0]?.volume?.ToList();

            var timeStampList = result[0]?.timestamp?.ToList();
            var timeStampToDateTime = ConvertUnixTimestamp.ConvertFromUnixTimestamp( timeStampList );

            for( int i = 0; i < result[0].timestamp.Count(); i++ )
            {
                if ( result[0].indicators.quote[0].open[i] == null )
                {
                    result[0].indicators.quote[0].open[i] = 0;
                }
                if (result[0].indicators.quote[0].close[i] == null)
                {
                    result[0].indicators.quote[0].close[i] = 0;
                }
                if (result[0].indicators.quote[0].high[i] == null)
                {
                    result[0].indicators.quote[0].high[i] = 0;
                }
                if (result[0].indicators.quote[0].low[i] == null)
                {
                    result[0].indicators.quote[0].low[i] = 0;
                }
                if (result[0].indicators.quote[0].volume[i] == null)
                {
                    result[0].indicators.quote[0].volume[i] = 0;
                }
            }
            
            List<StockChartViewModel> stockChartViewModels = new List<StockChartViewModel>();

            for (int i = 0; i < result[0].timestamp.Count(); i++)
            {
                stockChartViewModels.Add(new StockChartViewModel { close = close[i], date = timeStampToDateTime[i], 
                                                                   high = high[i], low = low[i], open = open[i], volume = vol });
            }

            StockChartResult = stockChartViewModels;
            ViewData["StockChartResult"] = stockChartViewModels;
            ViewData["StockName"] = result[0].meta.symbol.ToString();
        }


        





    }
}
