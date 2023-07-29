using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Infrastructure.Shared;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.API.WatchList;
using System.Net.Http.Headers;
using System.Text.Json;

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
                return RedirectToPage( "400_BadRequest" );
            }

            var userId = _watchListRepo.GetUserIdByEmail( user.ToString() );

            if( userId == string.Empty || userId == null )
            {
                return RedirectToPage("404_NotFound");
            }

            var symbolList = _watchListRepo.SymbolList();

            // 심볼리스트에 유저가 찾은 티커가 존재하는지 찾는다.
            var existCheck = symbolList.Exists( x => x.Symbol == symbol );
            
            if( existCheck == false )
            {
                return RedirectToPage("Cannot_Find");
            }

            // symbol도 null이 아니고 userId도 null이 아닐 때!
            // DB에 저장한다.
            var result = _watchListRepo.AddSymbol( userId, symbol );

            if( Convert.ToInt32( result.Value ) != 1 )
            {
                return RedirectToPage("CustomPage/500_ServerError");
            }

            return RedirectToPage("Index");
        }


        public ActionResult OnPostGetUserWishList( string userId )
        {
           
            if( userId == string.Empty || userId == null )
            {
                return RedirectToPage("CustomPage/400_BadRequest");
            }

            var result = _watchListRepo.GetUserWishList( userId );

            ViewData["WishList"] = result;

            return RedirectToPage("Index");
        }

        

    }
}
