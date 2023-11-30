using Microsoft.Extensions.Configuration;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.DashBoard;
using StockTrade.Application.ViewModel.Trade;
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
    public class DashBoardService : IDashBoardRepository
    {
        private readonly IConfiguration _configuration;

        public DashBoardService( IConfiguration configuration )
        {
            _configuration = configuration;
        }



        public async Task<List<DashBoardChartViewModel>> GetDashBoardProperties( string userId )
        {
            using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("DefaultConnection")) )
            {
                var cmd = new SqlCommand( "usp_GetUserOwnedStocks", connection );
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue( "@UserId", userId );

                connection.Open();
                 SqlDataReader reader = cmd.ExecuteReader();

                List<DashBoardChartViewModel> dashBoardChartViewList = new List<DashBoardChartViewModel>();
                
                while (reader.Read())
                {
                    DashBoardChartViewModel dashBoardChartView = new DashBoardChartViewModel();
                    dashBoardChartView.Symbol = Convert.ToString(reader["Symbol"]);
                    dashBoardChartView.Quantities = Convert.ToInt32(reader["Quantities"]);
                    dashBoardChartView.AvgPrice = Convert.ToDouble(reader["AvgPrice"]);

                    dashBoardChartViewList.Add( dashBoardChartView );
                }
                
                await connection.CloseAsync();

                return dashBoardChartViewList;
            }
        }


    }
}
