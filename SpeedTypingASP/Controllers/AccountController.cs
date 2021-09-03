using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Models;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace SpeedTypingASP.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<UserInformation> userManager;
        private readonly SignInManager<UserInformation> signInManager;
        public AccountController(UserManager<UserInformation> userManager, SignInManager<UserInformation> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Index(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string resultUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    SignInResult result =
                        await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                        return Redirect(resultUrl ?? "/");
                    ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
                }
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
