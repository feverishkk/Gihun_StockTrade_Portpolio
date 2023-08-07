using StockTrade.Application.ViewModel.API.Screener.PopularWatchlistDetail;
using StockTrade.Application.ViewModel.API.Screener.Portfolio;
using StockTrade.Application.ViewModel.API.ScreenerViewModel.Performance;

namespace StockTrade.Application.Interfaces.API
{
    public interface IScreenerAPIRepository
    {
        Task<PopularWatchlists> GetPopularWatchlists();

        Task<PopularWatchlistDetail> GetPopularWatchlistDetail( string pfId );

        Task<Performance> GetPopularWatchlistPerformance( string pfId );

    }
}
