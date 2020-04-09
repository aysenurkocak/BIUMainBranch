using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIUPocoLib
{
    /// <summary>
    /// Bu class KM Db ye eklediğimiz tablolara ait bilgi,hata detaylarını tutar
    /// </summary>
    public class Log
    {
        public int LogID { get; set; }
        public string LogName { get; set; }
        public string FunctionName { get; set; }
        public string LogType { get; set; }
        public DateTime LogDate { get; set; }
        public string Details { get; set; }
    }

    public enum LogType
    {
        Error = 1,
        Warning = 2,
        Information = 3,
        SuccessAudit = 4,
        FailureAudit = 5
    }
}
