using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.Trade
{
    public class TradeViewModel
    {
        public string userId { get; set; } = string.Empty;
        //[MinLength(1), MaxLength(2)]
        public int flag { get; set; }
        public string symbol { get; set; } = string.Empty;
        public double symbolPrice { get; set; }
        public int symbolQuantities { get; set; }
    }
}


