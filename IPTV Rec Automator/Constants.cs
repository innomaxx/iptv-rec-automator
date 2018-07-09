using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV_Rec_Automator
{
    internal class Constants
    {
        internal const double TimerTickInterval = 1e3;
        internal const string DefaultURI = "http://127.0.0.1:1331";
        internal const string ComparisonPattern = "hh:mm:ss";
        internal const string TestErrorMessage = "Не вдалося з'єднатися з програмою";
    }
}
