using Newtonsoft.Json;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Services
{
    public class SearchStockListService : ISearchStockListRepository
    {



        public List<StockSymbol>? SymbolList()
        {
            var location = @"C:\Users\gihun\source\repos\Stock_Project_Portfolio\StockProject.Infrastructure.Shared\StockList\nasdaq-listed.json";
            var list = JsonConvert.DeserializeObject<List<StockSymbol>>(File.ReadAllText(location));

            return list;

        }



    }
}
