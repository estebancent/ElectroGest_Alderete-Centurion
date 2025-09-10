using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroGest.Utils
{

    public static class PasswordHasher
    {
        // Hashea un password en SHA256 y lo devuelve en HEX
        public static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToHexString(hash).ToLower(); // hex en minúsculas
            }
        }

        // Verifica si el password ingresado coincide con el hash guardado
        public static bool VerifyPassword(string password, string storedHash)
        {
            var hashOfInput = HashPassword(password);
            return hashOfInput == storedHash.ToLower();
        }
    }
}