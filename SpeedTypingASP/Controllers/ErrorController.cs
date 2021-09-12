using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpeedTypingASP.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        [Route("Error/403")]
        public ActionResult Forbidden()
        {
            Response.StatusCode = 403;
            return View();
        }

        [Route("Error")]
        public ActionResult ServerError()
        {
            Response.StatusCode = 500;
            return View();
        }
    }
}
