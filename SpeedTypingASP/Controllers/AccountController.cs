﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Models;
using SpeedTypingASP.Service; 

namespace SpeedTypingASP.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<UserInformation> userManager;
        private readonly SignInManager<UserInformation> signInManager;
        public AccountController(
            UserManager<UserInformation> userManager,
            SignInManager<UserInformation> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result =
                        await signInManager
                            .PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                        return Redirect(returnUrl ?? "/");
                    ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
                }
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Register(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            ViewBag.returnUrl = returnUrl;
            return View(new RegisterViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (model.Password == model.ConfirmedPassword)
                {
                    var userId = Guid.NewGuid().ToString();
                    var user = new UserInformation()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        Id = userId,
                        PasswordHash = new PasswordHasher<UserInformation>().HashPassword(null, model.Password)
                    };
                    var result = await userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "user");
                        await signInManager
                                .PasswordSignInAsync(user, model.Password, false, false);
                        return Redirect(returnUrl ?? "/");
                    }
                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
                if (model.Password != model.ConfirmedPassword)
                    ModelState.AddModelError(nameof(RegisterViewModel.Password), "Пароли не совпадают");
            }
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public async Task<IActionResult> PersonalAccount()
        {
            if(signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                return View(user);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveTextStatistics(string textTitle)
        {
            if (signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                user.NormalStatisticType.RemoveTextStatisticsByName(textTitle);
                await userManager.UpdateAsync(user);
                return View("PersonalAccount", user);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
