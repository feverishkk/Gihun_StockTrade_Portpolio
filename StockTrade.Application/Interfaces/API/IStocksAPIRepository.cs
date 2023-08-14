using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.ViewModel.API.StocksViewModel.StockChart;

namespace StockTrade.Application.Interfaces.API
{
    public interface IStocksAPIRepository
    {
        Task<CompanyBrief> GetCompanyBrief( string symbol );
        Task<StockChart> GetStockChartMax( string symbol );
    }
}
