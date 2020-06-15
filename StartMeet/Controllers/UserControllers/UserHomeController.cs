using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index() => View("Index");

        [Authorize]
        public async Task<IActionResult> UserProperties()
        {
            return View(await CurrentUser);
        }

        [Authorize(Roles = "Users")]
        public IActionResult OtherAction() => View(UserProperties());

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UserProperties([Required]Cities city, [Required]Genders gender)
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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        private Task<AppUser> CurrentUser => userManager.FindByNameAsync(HttpContext.User.Identity.Name);

    }
}
