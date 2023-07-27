using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrade.Application.Interfaces;
using StockTrade.Application.ViewModel.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace Gihun_StockTrade_Portpolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApplicationUserRepository _applicationUser;
        private int keySize = 64;
        private int iterations = 2904000;

        private readonly ILogger<IndexModel> _logger;


        public IndexModel(ILogger<IndexModel> logger, IApplicationUserRepository applicationUser)
        {
            _logger = logger;
            _applicationUser = applicationUser;
        }

        public void OnGet()
        {

        }

        
        public IActionResult OnPost(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Privacy");
            }
            else
            {
                if (model.Password != model.ConfirmPassword)
                {
                    return BadRequest("Password is Differrent between Password And ConfirmPassword");
                }

                var hash = HashPassword(model.Password, out var salt);
                model.UserId = Guid.NewGuid();
                model.RoleId = 1;
                model.Password = hash;

                var result = _applicationUser.Register22(model);

                if( Convert.ToInt32( result.SqlValue.ToString() ) == 0)
                {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Privacy");
            }
        }


        private string HashPassword(string password, out byte[] salt)
        {

            var hashAlgorithm = HashAlgorithmName.SHA512;
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password),
                       salt,
            iterations,
                       hashAlgorithm,
                       keySize);

            return Convert.ToHexString(hash);
        }

        private bool VerifyPassword(string password, string hash, byte[] salt)
        {
            // 로그인할 때
            var hashAlgorithm = HashAlgorithmName.SHA512;
            var hashToComapare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);

            return CryptographicOperations.FixedTimeEquals(hashToComapare, Convert.FromHexString(hash));
        }





    }
}