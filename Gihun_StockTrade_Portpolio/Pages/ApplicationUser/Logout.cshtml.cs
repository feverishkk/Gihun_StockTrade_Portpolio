using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Gihun_StockTrade_Portpolio.Pages.ApplicationUser
{
    public class LogoutModel : PageModel
    {
        public void OnGetLogOut()
        {
        }

        public IActionResult OnPostLogOut()
        {

            if (HttpContext.Request.Cookies.Count > 0)
            {
                foreach (var item in HttpContext.Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(item);
                }
            }
            else
            {
                return RedirectToPage("/CustomPage/400_BadRequest");
            }

            return RedirectToPage("/Index");
        }


    }
}
