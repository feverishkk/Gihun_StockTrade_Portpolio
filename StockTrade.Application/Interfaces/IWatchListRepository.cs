
using StockProject.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Interfaces
{
    public interface IWatchListRepository
    {
        public List<StockSymbol>? SymbolList();
        string GetUserIdByEmail(string email);
        SqlParameter AddSymbol( string userId, string symbol );

        List<string> GetUserWishList( string userId ); 

    }
}
