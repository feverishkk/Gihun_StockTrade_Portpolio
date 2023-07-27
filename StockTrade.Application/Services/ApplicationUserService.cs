using Microsoft.Extensions.Configuration;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.Services
{
    public class ApplicationUserService : IApplicationUserRepository
    {
        private readonly IConfiguration _configuration;

        public ApplicationUserService( IConfiguration configuration )
        {
            _configuration = configuration;
        }

        public void Register(RegisterViewModel model)
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand("usp_RegisterUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.Parameters.AddWithValue("@UserId", model.UserId.ToString());
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@MemberSince", model.MemeberSince);
                cmd.Parameters.AddWithValue("@Birthday", model.Birthday);
                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@IsConfirmed", model.IsConfirmed);
                cmd.Parameters.AddWithValue("@Mobile", model.Mobile);
                cmd.Parameters.AddWithValue("@PostCode", model.PostCode);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@RoleId", model.RoleId);
                cmd.Parameters.AddWithValue("@Flag", "회원가입");

                cmd.ExecuteNonQuery();
            }
        }

        
        public SqlParameter Register22(RegisterViewModel model)
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand("usp_RegisterUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", model.UserId.ToString());
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@MemberSince", model.MemeberSince);
                cmd.Parameters.AddWithValue("@Birthday", model.Birthday);
                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@IsConfirmed", model.IsConfirmed);
                cmd.Parameters.AddWithValue("@Mobile", model.Mobile);
                cmd.Parameters.AddWithValue("@PostCode", model.PostCode);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@RoleId", model.RoleId);
                cmd.Parameters.AddWithValue("@Flag", "회원가입");
                //cmd.Parameters.AddWithValue("@Result", 1);

                SqlParameter outputParam = new SqlParameter();
                outputParam.ParameterName = "@Result";
                outputParam.Direction = ParameterDirection.Output;
                outputParam.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(outputParam);

                connection.Open();
                //SqlParameter outputParam = cmd.Parameters.Add("@Result", SqlDbType.Int);
                //outputParam.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();

                return outputParam;
            }
        }




    }
}
