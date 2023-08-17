using StockTrade.Application.ViewModel.Users;
using System.Data.SqlClient;

namespace StockTrade.Application.Interfaces
{
    public interface IApplicationUserRepository
    {
        SqlParameter Register(RegisterViewModel model);

    }
}
