using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.API.MarketViewModel.Crypto;

namespace Gihun_StockTrade_Portpolio.Pages.Market
{
    public class CryptoModel : PageModel
    {
        private readonly IMarketAPIRepository _marketAPIRepo;
        public List<Quote> CryptoResult { get; set; }

        public CryptoModel( IMarketAPIRepository marketAPIRepo )
        {
            _marketAPIRepo = marketAPIRepo; 
        }

        public async Task OnGet()
        {
            await OnGetCrypto();
        }

        public async Task OnGetCrypto()
        {
            var result = await _marketAPIRepo.GetCrypto();

            if ( result == null )
            {
                return;
            }

            CryptoResult = result.finance.result[0].quotes;
        }



    }
}
