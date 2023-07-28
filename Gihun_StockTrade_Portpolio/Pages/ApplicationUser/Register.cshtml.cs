using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.Users;
using StockProject.Infrastructure.Shared.ApplicationUser;

namespace Gihun_StockTrade_Portpolio.Pages.ApplicationUser
{
    public class IndexModel : PageModel
    {
        private readonly IApplicationUserRepository _applicationUser;

        public IndexModel( IApplicationUserRepository applicationUser )
        {
            _applicationUser = applicationUser;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostRegister(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CustomPage/404_NotFound");
            }
            else
            {
                if (model.Password != model.ConfirmPassword)
                {
                    return BadRequest("CustomPage/400_BadRequest");
                }

                var hash = HashAndVerify.HashPassword(model.Password, out var salt);
                model.UserId = Guid.NewGuid();
                model.RoleId = 1;
                model.Password = hash;

                var result = _applicationUser.Register(model);

                // 0 == ¼º°ø
                if ( Convert.ToInt32( result.SqlValue.ToString() ) == 0 )
                {
                    return RedirectToAction("/Index");
                }

                return RedirectToAction("CustomPage/400_BadRequest");
            }
        }

        





    }
}
