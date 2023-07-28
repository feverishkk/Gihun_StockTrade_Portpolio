
using StockProject.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Interfaces
{
    public interface ISearchStockListRepository
    {
        public List<StockSymbol>? SymbolList();


    }
}
