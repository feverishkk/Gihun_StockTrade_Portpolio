using StockTrade.Application.ViewModel.API.WatchList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Interfaces.API
{
    public interface IWatchListAPIRepository
    {
        Task<Summary> OnPostGetUserWishSymbolInfo(string wishSymbol);







    }
}
