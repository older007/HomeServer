using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unity3dLogs.Models
{
    public class HoloLog
    {
        public string LogMessage { get; set; }
        public string LogStackTrace { get; set; }
        public string LogTime { get; set; }
        public string LogType { get; set; }
    }
}
