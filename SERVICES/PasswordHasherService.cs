using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public static class PasswordHasherService
    {
        public static string Hash(string password, byte[]? storedSalt = null)
        {
            byte[] salt = new byte[128 / 8];
            if(storedSalt != null)
            {
                salt = storedSalt;
            }
            else
            {
                using var rng = RandomNumberGenerator.Create();
                rng.GetNonZeroBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 13000,
            numBytesRequested: 256 / 8));
            hashed = hashed + "@" + Convert.ToBase64String(salt);

            return hashed;
        }
        public static bool VerifyPassword(string userEnteredPassword, string dbPasswordHash)
        {
            string salt = dbPasswordHash.Split('@')[1];
            return dbPasswordHash == Hash(userEnteredPassword, System.Convert.FromBase64String(salt));

        }
    }
}
