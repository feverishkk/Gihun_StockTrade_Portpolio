using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gihun_StockTrade_Portpolio.Pages.DashBoard
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }


        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }
    }
}
