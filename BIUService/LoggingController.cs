
using BIUPocoLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BIUService
{
    public class LoggingController
    {
        /// <summary>
        /// BIU sheması altındaki tablolarda oluşan değişikliklerin kaydını tutmak için oluşturuldu. 
        /// </summary>
        /// <param name="log"></param>
       public  void WriteBIULog(string logName, string FunctionName, LogType type, string details)
        {
            try
            {
                using (BIUEFLib.Context.BIUDbContext db = new BIUEFLib.Context.BIUDbContext())
                {
                    Log log = new Log();
                    log.LogName = logName;
                    if (type == LogType.Error)
                        log.LogType = "Error";
                    else if (type == LogType.Information)
                        log.LogType = "Information";
                    else if (type == LogType.Warning)
                        log.LogType = "Warning";
                    else if (type == LogType.FailureAudit)
                        log.LogType = "FailureAudit";
                    else
                        log.LogType = "SuccessAudit";
                    log.Details = details;
                    log.FunctionName = FunctionName;
                    log.LogDate = DateTime.Now;
                    db.Log.Add(log);
                    db.SaveChanges();
                }
             }
            catch(Exception ex)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu.");
            }
        }
    }
}
