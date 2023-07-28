using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;

namespace Gihun_StockTrade_Portpolio.Pages.WatchList
{
    public class IndexModel : PageModel
    {
        private readonly ISearchStockListRepository _searchStockListRepository;

        public IndexModel( ISearchStockListRepository searchStockListRepository )
        {
            _searchStockListRepository = searchStockListRepository;
        }

        public void OnGet()
        {
        }

        public ActionResult OnPostAddSymbol( string symbol )
        {
            return RedirectToAction("Index");
        }


    }
}
