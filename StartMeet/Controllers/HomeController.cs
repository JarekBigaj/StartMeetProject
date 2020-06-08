
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StartMeet.Models;
using StartMeet.Models.ViewModels;

namespace StartMeet.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        public HomeController(UserManager<AppUser> usrMgr , SignInManager<AppUser> signinManager)
        {
            userManager = usrMgr;
            signInManager = signinManager;
        }
        public ViewResult Index() => View();


        #region Registration
        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(MultipleAccountSettingsModel model)
        {
            
            if (ModelState.IsValid)
            {
                
                AppUser user = new AppUser
                {
                    UserName = model.RegisterModel.Name,
                    Email = model.RegisterModel.Email,
                    PasswordHash = model.RegisterModel.Password,
                    City = model.RegisterModel.City,
                    Day = model.RegisterModel.Day,
                    Month = model.RegisterModel.Month,
                    Year = model.RegisterModel.Year,
                    Gender = model.RegisterModel.Gender
                    
                };
                IdentityResult result = await userManager.CreateAsync(user, model.RegisterModel.Password);

                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View("Index");
        }

        #endregion

        #region Login
        [Authorize]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(MultipleAccountSettingsModel details, string returnUrl)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(details.SignInModel.Email);
                if(user !=null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await signInManager.PasswordSignInAsync(user, details.SignInModel.Password, false, false);
                    if(result .Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }

                ModelState.AddModelError(nameof(MultipleAccountSettingsModel.SignInModel.Email),
                    "Invalid username or password.");
            }
            return View("Index");
        }
        #endregion

        
    }
}