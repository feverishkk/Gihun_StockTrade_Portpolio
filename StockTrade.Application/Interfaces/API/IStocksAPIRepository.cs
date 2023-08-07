using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;

namespace StockTrade.Application.Interfaces.API
{
    public interface IStocksAPIRepository
    {
        Task<CompanyBrief> GetCompanyBrief( string symbol );
    }
}
