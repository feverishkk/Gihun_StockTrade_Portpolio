using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;

namespace StockTrade.Application.Interfaces.API
{
    public interface IStocksRepository
    {
        Task<CompanyBrief> GetCompanyBrief( string symbol );
    }
}
