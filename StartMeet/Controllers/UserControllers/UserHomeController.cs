using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StartMeet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StartMeet.Controllers.UserControllers
{
    public class UserHomeController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public UserHomeController(UserManager<AppUser> userMgr , SignInManager<AppUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [Authorize]
        public IActionResult Index() => View(GetData(nameof(Index)));

        [Authorize(Roles = "Users")]
        public IActionResult OtherAction() => View("Index", GetData(nameof(OtherAction)));

        private Dictionary<string, object> GetData(string actionName) =>
            new Dictionary<string, object>
            {
                ["Action"] = actionName,
                ["User"] = HttpContext.User.Identity.Name,
                ["Is Authenticated ?"] = HttpContext.User.Identity.IsAuthenticated,
                ["Authenticated Type"] = HttpContext.User.Identity.AuthenticationType,
                ["Assigned to the role Users?"] = HttpContext.User.IsInRole("Users")
            };

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
