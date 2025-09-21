using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Helper
{
    public class PasswordHasher
    {
        public static (string Hash, byte[] Salt) HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = 8,
                MemorySize = 65536,
                Iterations = 4
            };

            byte[] hash = argon2.GetBytes(32);
            return (Convert.ToBase64String(hash), salt);
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash, byte[] storedSalt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(enteredPassword))
            {
                Salt = storedSalt,
                DegreeOfParallelism = 8,
                MemorySize = 65536,
                Iterations = 4
            };

            byte[] hash = argon2.GetBytes(32);
            string enteredHash = Convert.ToBase64String(hash);

            return enteredHash == storedHash;
        }

    }
}
