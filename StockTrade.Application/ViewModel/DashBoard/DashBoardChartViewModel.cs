using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.DashBoard
{
    public class DashBoardChartViewModel
    {
        public double AvgPrice { get; set; }
        public int Quantities { get; set; }
        public string  Symbol { get; set; }
        public double Balance { get; set; }
        public double Property { get; set; }
    }
}
