using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Helper
{
    public class OnLoadFormDirect
    {
        private readonly PulseDbContext _db;
        public OnLoadFormDirect(PulseDbContext db)
        {
            _db = db;
        }
        public string whichForm()
        {
            bool hasUsers = _db.Users.Any();
            return hasUsers ? "login" : "register";
        }
    }
}
