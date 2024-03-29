﻿using Microsoft.Extensions.Configuration;
using StockTrade.Application.Interfaces;
using System.Data.SqlClient;
using System.Data;
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

                await connection.OpenAsync();

                await cmd.ExecuteNonQueryAsync();

                return outputParam;
            }
        }



    }
}
