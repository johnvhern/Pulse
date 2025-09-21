using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Helper
{
    public static class UserSession
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Name { get; private set; }
        public static bool IsLoggedIn => UserId != 0;

        public static void SetUser(int userId, string username, string name)
        {
            UserId = userId;
            Username = username;
            Name = name;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Name = null;
        }
    }

}
