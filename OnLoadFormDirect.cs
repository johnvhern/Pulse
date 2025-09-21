using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse
{
    public class OnLoadFormDirect
    {
        public string whichForm()
        {
            var options = new DbContextOptionsBuilder<PulseDbContext>()
                .UseSqlite($"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PulseDB.db")}")
                .Options;

            // Create context
            var context = new PulseDbContext(options);

            bool hasUsers = context.Users.Any();
            return hasUsers ? "login" : "register";
        }
    }
}
