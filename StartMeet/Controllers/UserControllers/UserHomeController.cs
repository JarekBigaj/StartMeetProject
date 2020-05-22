using AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using StartMeet.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                ["Assigned to the role Users?"] = HttpContext.User.IsInRole("Users"),
                ["Town"] = CurrentUser.Result.City,
                ["Gender"] = CurrentUser.Result.Gender
            };

        [Authorize]
        public async Task<IActionResult> UserProps()
        {
            return View(await CurrentUser);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UserProps(
            [Required]Cities city,
            [Required]Genders gender)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await CurrentUser;
                user.City = city;
                user.Gender = gender;
                await userManager.UpdateAsync(user);
                return RedirectToAction("Index");
            }
            return View(await CurrentUser);
        }
        private Task<AppUser> CurrentUser => userManager.FindByNameAsync(HttpContext.User.Identity.Name);

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
