using System.Security.Cryptography;
using System.Text;

namespace StockProject.Infrastructure.Shared.ApplicationUser
{
    public static class HashAndVerify
    {
        public static int keySize = 64;
        public static int iterations = 2904000;

        public static string HashPassword(string password, out byte[] salt)
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

        public static bool VerifyPassword(string password, string hash, byte[] salt)
        {
            // 로그인할 때
            var hashAlgorithm = HashAlgorithmName.SHA512;
            var hashToComapare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);

            return CryptographicOperations.FixedTimeEquals(hashToComapare, Convert.FromHexString(hash));
        }



    }
}
