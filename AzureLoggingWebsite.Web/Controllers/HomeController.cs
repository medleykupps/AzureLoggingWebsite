using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureLoggingWebsite.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Homepage()
        {
            Trace.WriteLine("Entering Homepage action");

            // Output an Information level message
            Trace.TraceInformation("Generate Information trace at {0}", DateTime.Now);

            // Output a Warning level message
            Trace.TraceWarning("Generate Warning trace at {0}", DateTime.Now);

            // Output an Error level message
            Trace.TraceError("Generate Error trace at {0}", DateTime.Now);

            return View();
        }
    }
}