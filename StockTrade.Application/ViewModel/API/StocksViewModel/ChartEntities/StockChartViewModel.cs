using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.StocksViewModel.ChartEntities
{
    public class StockChartViewModel
    {

        public object open { get; set; }
        public object volume { get; set; }
        public object high { get; set; }
        public object low { get; set; }
        public object close { get; set; }    
        public string date { get; set; }
    }
}
