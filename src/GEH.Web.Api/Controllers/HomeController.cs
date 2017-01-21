using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GEH.Web.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // GET: /<controller>/
        [Route("~/index")]
        public IActionResult Index()
        {
            _logger.LogWarning("Index action - warning");
            return Ok();
        }
        [Route("~/debug")]
        public IActionResult Debug()
        {
            _logger.LogDebug("Debug action - debug");
            return Ok();
        }

        [Route("~/error")]
        public IActionResult Error()
        {
            RaiseException();
            return Ok();
        }

        private void RaiseException()
        {
            throw new Exception("App exception raised. - error");

        }
    }
}
