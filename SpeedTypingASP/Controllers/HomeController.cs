using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Domain.Entities;
using SpeedTypingASP.Models;

namespace SpeedTypingASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<UserInformation> userManager;
        private readonly SignInManager<UserInformation> signInManager;
        public HomeController(DataManager dataManager, UserManager<UserInformation> userManager, SignInManager<UserInformation> signInManager)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.Texts.GetTexts());
        }
        public IActionResult TextWrite(string textTitle)
        {
            var text = dataManager.Texts.GetTexts().FirstOrDefault(x=> x.Title == textTitle);
            //todo вклюить и проверить
            //if(text == null)
            //    return RedirectToAction("Index", "Home");
            return View(text);
        }
        [HttpPost]
        public async Task<IActionResult> TextWriteResult(
            string textTitle, 
            string countOfErrors,
            string countOfCorrects,
            string time)
        {
            var text = dataManager.Texts.GetTextByName(textTitle);
            var textStatistics = new TextStatistics()
            {
                MinCountOfErrors = int.Parse(countOfErrors),
                MaxCountOfCorrects = int.Parse(countOfCorrects),
                TextId = text.Id,
                MinMiliseconds = int.Parse(time)
            };

            var resultViewModel = new TextWriteResultViewModel() { CurrentTextStatistics = textStatistics, TextTitle = textTitle };

            if(signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                var bestStatistics = user.SetTextStatisticsAndGetBestStatistics(textStatistics);
                resultViewModel.BestTextStatistics = bestStatistics;
                var result = await userManager.UpdateAsync(user);
                if(!result.Succeeded)
                    resultViewModel.BestTextStatistics = null;

            }
            return View(resultViewModel);
        }
    }
}
