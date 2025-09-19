using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Helper
{
    public static class DataUpdateNotifier
    {
        public static event Action? DataUpdated;

        public static void NotifyDataUpdated()
        {
            DataUpdated?.Invoke();
        }
    }

}
