using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Application.ViewModel.API.StocksViewModel.CompanyBrief;
using StockTrade.Application.Interfaces;
using StockTrade.Application.Interfaces.API;
using StockTrade.Application.ViewModel.DashBoard;

namespace Gihun_StockTrade_Portpolio.Pages.DashBoard
{
    public class IndexModel : PageModel
    {
        private readonly IStocksAPIRepository _stocksAPIRepo;
        private readonly IDashBoardRepository _dashBoardRepository;

        public CompanyBrief companyBrief { get; set; }
        public List<DashBoardChartViewModel> DashBoardChartView { get; set; }

        public IndexModel( IStocksAPIRepository stocksAPIRepo, IDashBoardRepository boardRepository )
        {
            _stocksAPIRepo = stocksAPIRepo;
            _dashBoardRepository = boardRepository; 
        }

        public void OnGet()
        {
        }


        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }



        public async Task<ActionResult> OnPostCompanyBrief( string clickedSymbol )
        {
            if ( clickedSymbol == string.Empty || clickedSymbol == null )
            {
                return RedirectToPage("CustomPage/404_NotFound");
            }

            var info = await _stocksAPIRepo.GetCompanyBrief( clickedSymbol );

            if ( info == null )
            {
                return RedirectToPage("CustomPage/404_NotFound");
            }

            companyBrief = info;

            return null;
        }

        public async Task OnPostUserProperties( string userId )
        {
            if( userId == string.Empty || userId == null )
            {
                return;
            }

            var result = _dashBoardRepository.GetDashBoardProperties( userId ).Result;

            if ( result == null )
            {
                return;
            }

            List<DashBoardChartViewModel> chartViewModels = new List<DashBoardChartViewModel>();

            int totalQuantities = 0;

            foreach ( var item in result )
            {
                totalQuantities += item.Quantities;
            }

            totalQuantities = totalQuantities / 100;

            foreach ( var item in result )
            {
                chartViewModels.Add( new DashBoardChartViewModel { AvgPrice   = item.AvgPrice,   Property = item.Quantities / totalQuantities,
                                                                   Quantities = item.Quantities, Symbol  = item.Symbol.ToUpper() } );
            }
            ViewData["SymbolName"] = result[0].Symbol.ToString();
            DashBoardChartView = chartViewModels ;
        }






    }
}
