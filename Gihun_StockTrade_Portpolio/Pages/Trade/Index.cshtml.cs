using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.StocksViewModel.ChartEntities;
using StockTrade.Application.ViewModel.API.StocksViewModel.StockChart;
using StockTrade.Application.ViewModel.Trade;

namespace Gihun_StockTrade_Portpolio.Pages.Trade
{
    public class IndexModel : PageModel
    {
        private readonly ITradeRepository _tradeRepo;
        private readonly IWatchListRepository _watchListRepo;
        private readonly IStocksAPIRepository _stocksAPIRepo;
       
        public List<StockChartViewModel> StockChartResult { get; set; }

        public IndexModel( ITradeRepository tradeRepository, IWatchListRepository watchListRepository, IStocksAPIRepository stocksAPIRepository )
        {
            _tradeRepo = tradeRepository;
            _watchListRepo = watchListRepository; 
            _stocksAPIRepo = stocksAPIRepository;
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostTrade( [FromForm] TradeViewModel model )
        {
            if( !ModelState.IsValid )
            {
                return RedirectToPage("/Custom/404_NotFound");
            }

            if( model.userId == string.Empty || model.userId == null || model.symbol == string.Empty || model.symbol == null )
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            if( model.symbolPrice == 0 || model.symbolQuantities == 0 ) 
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            if( model.flag > 3 || model.flag < 0 )
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            var symbolList = _watchListRepo.SymbolList();

            bool isExistSymbol = symbolList.FindAll(x=>x.Symbol == model.symbol.ToUpper()).Any();

            if ( isExistSymbol == false )
            {
                return RedirectToPage("/Custom/404_NotFound");
            }

            var result = await _tradeRepo.Trade( model );

            // 성공
            if (Convert.ToInt32(result.SqlValue.ToString()) == 0 )
            {
                return RedirectToPage("/Trade/Index");
            }
            else
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }
        }

        public async Task OnPostGetStockChart( string symbol )
        {
            // 범위: Max, 간격은 1d의 데이터를 가져온다.
            var data = await _stocksAPIRepo.GetStockChartMax( symbol );

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

            for (int i = 0; i < result[0].timestamp.Count(); i++)
            {
                if (result[0].indicators.quote[0].open[i] == null)
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
                stockChartViewModels.Add(new StockChartViewModel
                {
                    close = close[i],
                    date = timeStampToDateTime[i],
                    high = high[i],
                    low = low[i],
                    open = open[i],
                    volume = vol
                });
            }

            StockChartResult = stockChartViewModels;
            ViewData["HiloOpenClose"] = stockChartViewModels;
            ViewData["StockName"] = result[0].meta.symbol.ToString();

        }

    }
}
