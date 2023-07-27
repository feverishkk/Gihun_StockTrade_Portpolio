using StockTrade.Domain.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StockTrade.Application.ViewModel.Interfaces
{
    public class RegisterViewModel : User
    {
        [Display(Name = "비밀번호")]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
