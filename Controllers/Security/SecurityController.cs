using Microsoft.AspNetCore.Mvc;

namespace flyer_expo_api.Controllers.Security
{
    [Produces("application/json")]
    [Route("api/Security")]
    public class SecurityController : Controller
    {
        [HttpGet]
        [Route("get-user-details")]
        public string GetUserDetails()
        {
            return "Ganesh Phadtare";
        }
    }
}