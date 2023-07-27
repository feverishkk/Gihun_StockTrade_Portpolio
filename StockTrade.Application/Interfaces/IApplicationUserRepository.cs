using StockTrade.Application.ViewModel.Interfaces;
using System.Data.SqlClient;

namespace StockTrade.Application.Interfaces
{
    public interface IApplicationUserRepository
    {

        void Register(RegisterViewModel model);

        SqlParameter Register22(RegisterViewModel model);

    }
}
