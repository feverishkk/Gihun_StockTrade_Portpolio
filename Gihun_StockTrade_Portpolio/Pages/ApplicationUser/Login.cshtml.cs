using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.ViewModel.Users;
using StockProject.Infrastructure.Shared.ApplicationUser;

namespace Gihun_StockTrade_Portpolio.Pages.ApplicationUser
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnGetLogin()
        {
        }

        public IActionResult OnPostLogin( LoginViewModel model )
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Privacy");
            }
            else
            {
                var hashedPassword = HashAndVerify.HashPassword( model.Password, out var salt );

                var isAuthenticated = HashAndVerify.VerifyPassword( model.Password, hashedPassword, salt );
                if (isAuthenticated == true)
                {
                    CookieOptions cookie = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(3),
                        Secure = true
                    };

                    Response.Cookies.Append( "Email", model.Email, cookie );

                    return RedirectToAction( "/Index" );
                }
            }

            return RedirectToAction("CustomPage/400_BadRequest");
        }



    }
}
