using StockTrade.Application.ViewModel.DashBoard;

namespace StockTrade.Application.Interfaces
{
    public interface IDashBoardRepository
    {
        Task<List<DashBoardChartViewModel>> GetDashBoardProperties( string userId );
    }
}
