using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail;
using StockTrade.Application.ViewModel.API.ScreenerViewModel.Performance;

namespace Gihun_StockTrade_Portpolio.Pages.Screener
{
    public class IndexModel : PageModel
    {
        private readonly IScreenerAPIRepository _screenerAPIRepo;

        public List<StockTrade.Application.ViewModel.API.Screener.Portfolio.Portfolio> portfolio { get; set; }
        public StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail.Result popularWatchlistDetails { get; set; }
        public Performance Performance { get; set; }

        public IndexModel( IScreenerAPIRepository screenerAPIRepo )
        {
            _screenerAPIRepo = screenerAPIRepo;
        }

        public async Task OnGetAsync()
        {
            await GetPopularWatchlists();
        }
        
        public async Task GetPopularWatchlists()
        {
            var watchList = await _screenerAPIRepo.GetPopularWatchlists();
            var result = watchList.finance.result.Select(x => x.portfolios).ToList();

            List<StockTrade.Application.ViewModel.API.Screener.Portfolio.Portfolio> portfolios = new List<StockTrade.Application.ViewModel.API.Screener.Portfolio.Portfolio>();

            foreach (var item in result[0])
            {
                portfolios.Add(item);
                
            }
            portfolio = portfolios;
            ViewData["portfolios"] = portfolios;

        }

        public async Task OnPostPopularWatchlistDetail( string pfId )
        {
            var detail = await _screenerAPIRepo.GetPopularWatchlistDetail( pfId );

            StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail.Result popularWatchlistDetailList = 
                                    new StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail.Result();

            foreach (var item in detail.finance.result)
            {
                popularWatchlistDetailList.portfolios = item.portfolios;
            }

            popularWatchlistDetails = popularWatchlistDetailList;

            await OnPostPopularWatchlistPerformance( pfId );
        }

        private async Task OnPostPopularWatchlistPerformance( string pfId )
        {
            var performance = await _screenerAPIRepo.GetPopularWatchlistPerformance( pfId );

            //Performance model = new Performance();  

            //model.finance.result[0].portfolio = performance.finance.result[0].portfolio;
            //model.finance.result[0].symbols = performance.finance.result[0].symbols;

            Performance = performance;
        }




    }
}
