using StockTrade.Application.ViewModel.API.MarketViewModel;
using StockTrade.Application.ViewModel.API.MarketViewModel.Crypto;

namespace StockTrade.Application.Interfaces.API
{
    public interface IMarketAPIRepository
    {
        Task<MarketNews> GetMarketNews();

        Task<Crypto> GetCrypto();




    }
}
