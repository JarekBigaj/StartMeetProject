using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StartMeet.Controllers.UserControllers
{
    public class AccountController : Controller
    {

        [AllowAnonymous]
        public IActionResult AccessDenied() => View();
    }
}
