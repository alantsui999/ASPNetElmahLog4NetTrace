using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetElmah.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        [OutputCache(Duration = 10)]
        public string Index()
        {
            return DateTime.Now.ToString("T");
        }
    }
}