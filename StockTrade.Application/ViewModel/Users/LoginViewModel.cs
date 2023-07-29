using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.Users
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}
