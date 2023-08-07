using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.Interfaces;
using StockTrade.Application.Interfaces.API;

namespace Gihun_StockTrade_Portpolio.Pages.WatchList
{
    public class IndexModel : PageModel
    {
        private readonly IWatchListRepository _watchListRepo;
        private readonly IStocksAPIRepository _stocksRepo;

        public CompanyBrief companyBrief { get; set; }

        public IndexModel( IWatchListRepository watchListRepo, IStocksAPIRepository stocksRepo )
        {
            _watchListRepo = watchListRepo;
            _stocksRepo = stocksRepo;
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

            // �ɺ�����Ʈ�� ������ ã�� ƼĿ�� �����ϴ��� ã�´�.
            var existCheck = symbolList.Exists( x => x.Symbol == symbol );
            
            if( existCheck == false )
            {
                return RedirectToPage("Cannot_Find");
            }

            // ��� ������ �����Ѵٸ�
            // ������ null�� �ƴϰ� ����Id�� �����԰� symbol�� �����Ѵٸ�
            // DB�� �����ϴ� ����
            if( user != null && user != string.Empty && userId != null && userId != string.Empty && existCheck == true )
            {
                // symbol�� null�� �ƴϰ� userId�� null�� �ƴϰ� ƼĿ�� �����Ѵٸ�!
                // DB�� �����Ѵ�.
                var result = _watchListRepo.AddSymbol(userId, symbol);

                if (Convert.ToInt32(result.Value) != 1)
                {
                    return RedirectToPage("CustomPage/500_ServerError");
                }
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

        public async Task<ActionResult> OnPostCompanyBrief( string clickedSymbol )
        {
            if( clickedSymbol ==  string.Empty || clickedSymbol == null )
            {
                return RedirectToPage("CustomPage/404_NotFound");
            }

            var info = await _stocksRepo.GetCompanyBrief( clickedSymbol );

            if ( info == null )
            {
                return null;
            }
            this.companyBrief = info;
            ViewData["companyBrief"] = info;

            return null;
        }

    }
}
