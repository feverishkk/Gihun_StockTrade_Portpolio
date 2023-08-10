using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.Trade;

namespace Gihun_StockTrade_Portpolio.Pages.Trade
{
    public class IndexModel : PageModel
    {
        private readonly ITradeRepository _tradeRepository;
        private readonly IWatchListRepository _watchListRepository;

        public IndexModel( ITradeRepository tradeRepository, IWatchListRepository watchListRepository )
        {
            _tradeRepository = tradeRepository;
            _watchListRepository = watchListRepository; 
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostTrade( [FromForm] TradeViewModel model )
        {
            if( !ModelState.IsValid )
            {
                return RedirectToPage("/Custom/404_NotFound");
            }

            if( model.userId == string.Empty || model.userId == null || model.symbol == string.Empty || model.symbol == null )
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            if( model.symbolPrice == 0 || model.symbolQuantities == 0 ) 
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            if( model.flag > 3 || model.flag < 0 )
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }

            var symbolList = _watchListRepository.SymbolList();

            bool isExistSymbol = symbolList.FindAll(x=>x.Symbol == model.symbol.ToUpper()).Any();

            if ( isExistSymbol == false )
            {
                return RedirectToPage("/Custom/404_NotFound");
            }

            var result = await _tradeRepository.Trade( model );

            // ¼º°ø
            if (Convert.ToInt32(result.SqlValue.ToString()) == 0 )
            {
                return RedirectToPage("/Trade/Index");
            }
            else
            {
                return RedirectToPage("/Custom/500_BadRequest");
            }
        }


    }
}
