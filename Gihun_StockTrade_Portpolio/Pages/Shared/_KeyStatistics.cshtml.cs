using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.Interfaces.API;

namespace Gihun_StockTrade_Portpolio.Pages.Shared
{
    public class _KeyStatisticsModel : PageModel
    {
        private readonly IStocksAPIRepository _stocksRepo;
        //public CompanyBrief companyBrief { get; set; }

        public _KeyStatisticsModel( IStocksAPIRepository stocksRepo )
        {
            _stocksRepo = stocksRepo;
        }

        public void OnGet()
        {
        }

        public async Task<CompanyBrief> OnGetCompanyBrief(string clickedSymbol)
        {
            string symbol = Request.Cookies["clickedValue"];
            var info = await _stocksRepo.GetCompanyBrief(symbol);

            if (info == null)
            {
                return null;
            }

            return info;
        }







    }
}
