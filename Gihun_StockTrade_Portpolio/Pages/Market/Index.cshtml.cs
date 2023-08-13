using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.MarketViewModel;

namespace Gihun_StockTrade_Portpolio.Pages.Market
{
    public class IndexModel : PageModel
    {
        private readonly IMarketAPIRepository _marketRepo;

        public IndexModel( IMarketAPIRepository marketRepo )
        {
            _marketRepo = marketRepo;
        }


        public void OnGet()
        {
        }

        public IActionResult OnGetCrypto()
        {
            return RedirectToPage("/Market/Crypto");
        }






    }
}
