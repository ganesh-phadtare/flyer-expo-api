using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace flyer_expo_api.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("my-dashboard")]
        public string MyDashboard()
        {
            return "Ganesh Phadtare";
        }
    }
}
