using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNetElmah.Models;
using ASPNetLogger;

namespace ASPNetElmah.Controllers
{
    /// <summary>
    /// 2019-04-10
    /// ASP.Net Logging
    /// Elmah - localhost:61872/elmah.axd
    /// Trace - localhost:61872/trace.axd
    /// log4net - /App_Data/Logs
    /// log file - /App_Data/log
    /// LogActionFilter - ActionFilterAttribute
    /// </summary>
    // private ILog _ILog;
    [LogActionFilter]
    public class HomeController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HomeController()
        {
            // _ILog = Log.GetInstance;
        }
  
        public ActionResult TestElmah()
        {
            log.Info("Test Elmah hit");
            ViewBag.Message = "Modify this Elmah template";
            return View();
        }

        public ActionResult Index()
        {

            ViewBag.Message = "Modify this Elmah template";
            log.Info("Index page hit");
            try
            {
                int number1 = 4;
                int number2 = 0;
                int number3 = number1 / number2;
            } catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            return View();
        }

        public ActionResult About()
        {
            log.Info("About page hit");
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}