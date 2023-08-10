using StockTrade.Application.ViewModel.Trade;
using System.Data.SqlClient;

namespace StockTrade.Application.Interfaces
{
    public interface ITradeRepository
    {
        Task<SqlParameter> Trade( TradeViewModel model );
    }
}
