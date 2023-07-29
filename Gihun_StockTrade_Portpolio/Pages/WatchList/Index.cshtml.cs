using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;

namespace Gihun_StockTrade_Portpolio.Pages.WatchList
{
    public class IndexModel : PageModel
    {
        private readonly IWatchListRepository _watchListRepo;

        public IndexModel( IWatchListRepository watchListRepo )
        {
            _watchListRepo = watchListRepo;
        }

        public void OnGet()
        {
        }

        public ActionResult OnPostAddSymbol( string symbol )
        {
            string user = Request.Cookies["Email"].ToString(); 

            if( user == null || user == string.Empty || symbol == null || symbol == string.Empty ) 
            {
                return RedirectToPage( "404_BadRequest" );
            }

            var userId = _watchListRepo.GetUserIdByEmail( user.ToString() );

            if( userId == string.Empty || userId == null )
            {
                return RedirectToPage("404_BadRequest");
            }

            var symbolList = _watchListRepo.SymbolList();

            // �ɺ�����Ʈ�� ������ ã�� ƼĿ�� �����ϴ��� ã�´�.
            var existCheck = symbolList.Exists( x => x.Symbol == symbol );
            
            if( existCheck == false )
            {
                return RedirectToPage("Cannot_Find");
            }

            // symbol�� null�� �ƴϰ� userId�� null�� �ƴ� ��!
            // DB�� �����Ѵ�.
            var result = _watchListRepo.AddSymbol( userId, symbol );

            if( Convert.ToInt32( result.Value ) != 1 )
            {
                return RedirectToPage("CustomPage/500_ServerError");
            }

            return RedirectToPage("Index");
        }


    }
}
