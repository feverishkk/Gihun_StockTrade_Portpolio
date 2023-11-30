using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Services
{
    public class WatchListService : IWatchListRepository
    {
        private readonly IConfiguration _configuration;

        public WatchListService( IConfiguration configuration )
        {
            _configuration = configuration;
        }

        public List<StockSymbol>? SymbolList()
        {
            var location = @"C:\Users\gihun\source\repos\Stock_Project_Portfolio\StockProject.Infrastructure.Shared\StockList\nasdaq-listed.json";
            var list = JsonConvert.DeserializeObject<List<StockSymbol>>(File.ReadAllText(location));

            return list;
        }
        public async Task<SqlParameter> AddSymbol( string Email, string symbol)
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand("usp_UserWishList_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", Email);
                cmd.Parameters.AddWithValue("@Symbol", symbol );

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

        public string GetUserIdByEmail( string email )
        {
            using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("DefaultConnection")) )
            {
                var cmd = new SqlCommand( "usp_GetUserIdByEmail", connection );
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue( "@Email", email );

                connection.Open();

                string value = (string)cmd.ExecuteScalar();

                return value;
            }
        }

        public List<string> GetUserWishList( string userId )
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand("usp_GetUserWishList", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue( "@UserId", userId );

                connection.Open();

                List<string> result = new List<string>();

                using(var reader =  cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }

                return result; 
            }
        }




    }
}
