using StockTrade.Application.ViewModel.Users;
using System.Data.SqlClient;

namespace StockTrade.Application.Interfaces
{
    public interface IApplicationUserRepository
    {

        //void Register(RegisterViewModel model);

        SqlParameter Register(RegisterViewModel model);

    }
}
