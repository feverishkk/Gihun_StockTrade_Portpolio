using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gihun_StockTrade_Portpolio.Pages
{
    public class IndexModel : PageModel
    {
       

        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


    }
}