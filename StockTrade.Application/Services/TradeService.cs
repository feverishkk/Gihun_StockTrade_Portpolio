using Microsoft.Extensions.Configuration;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.API.MarketViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTrade.Application.ViewModel.Trade;

namespace StockTrade.Application.Services
{
    public class TradeService : ITradeRepository
    {

        private readonly IConfiguration _configuration;

        public TradeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<SqlParameter> Trade( TradeViewModel model )
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand("usp_UserBuyAndSell_Stock", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue( "@UserId", model.userId );
                cmd.Parameters.AddWithValue( "@Flag", model.flag );
                cmd.Parameters.AddWithValue( "@Symbol", model.symbol );
                cmd.Parameters.AddWithValue( "@SymbolPrice", model.symbolPrice );
                cmd.Parameters.AddWithValue( "@SymbolQuantities", model.symbolQuantities );

                SqlParameter outputParam = new SqlParameter();
                outputParam.ParameterName = "@Result";
                outputParam.Direction = ParameterDirection.Output;
                outputParam.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outputParam);

                connection.Open();

                cmd.ExecuteNonQuery();

                return outputParam;
            }
        }



    }
}
