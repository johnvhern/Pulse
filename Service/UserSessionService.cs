using Pulse.Data;
using Pulse.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Service
{
    public class UserSessionService
    {
        private readonly PulseDbContext _db;

        public UserSessionService(PulseDbContext db)
        {
            _db = db;
        }

        public bool TryLoadUserSession()
        {
            if (!LoadUserSession())  // Your encrypted load method
                return false;

            var user = _db.Users.Find(UserSession.UserId);
            return user != null;
        }

        private bool LoadUserSession()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersession.dat");
            if (File.Exists(filePath))
            {
                try
                {
                    var encrypted = File.ReadAllBytes(filePath);

                    // Decrypt using DPAPI
                    var decrypted = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
                    var data = Encoding.UTF8.GetString(decrypted);

                    var parts = data.Split('|');
                    if (parts.Length == 3 && int.TryParse(parts[0], out int userId))
                    {
                        UserSession.SetUser(userId, parts[1], parts[2]);
                        return true;
                    }
                }
                catch
                {
                    // Handle errors, possibly corrupted
                }
            }
            return false;
        }
    }

}
