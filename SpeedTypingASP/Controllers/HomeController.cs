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
using SpeedTypingASP.Service;

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
        [HttpGet]
        [HttpPost]
        public IActionResult TextWrite(string textTitle, int textSize)
        {
            var text = dataManager.Texts.GetTexts().FirstOrDefault(x=> x.Title == textTitle);
            //todo вклюить и проверить
            if(text == null 
               || string.IsNullOrEmpty(text.TextContent) 
               || string.IsNullOrEmpty(text.Title) 
               || string.IsNullOrEmpty(text.Id))
                return RedirectToAction("Index", "Home");
            switch (textSize)
            {
                case 1:
                    if (text.TextContent.Length < 50)
                        break;
                    text.TextContent = text.TextContent.Substring(0, 50);
                    break;
                case 2:
                    text.TextContent = text.TextContent.Substring(
                        0,
                        (int)(text.TextContent.Length * .25));
                    break;
                case 3:
                    text.TextContent = text.TextContent.Substring(
                        0,
                        (int)(text.TextContent.Length * .5));
                    break;
                case 4:
                    text.TextContent = text.TextContent.Substring(
                        0,
                        (int)(text.TextContent.Length * .75));
                    break;
                case 5:
                    break;
            }
            return View(new TextWriteViewModel(){Text = text, TextSize = textSize});
        }
        [HttpPost]
        public async Task<IActionResult> TextWriteResult(
            int textSize,
            string textTitle, 
            string countOfErrors,
            string countOfCorrects,
            string time)
        {
            var text = dataManager.Texts.GetTextByName(textTitle);
            var miliseconds = int.Parse(time);
            var minutes = miliseconds / 6000d;
            var errors = int.Parse(countOfErrors);
            var corrects = int.Parse(countOfCorrects);

            var textStatistics = new TextStatistics()
            {
                CountOfErrors = errors,
                CountOfCorrects = corrects,
                TextId = text.Id,
                Miliseconds = miliseconds,
                CharactersPerMinute = Math.Round(corrects / (minutes == 0 ? .0001d : minutes), 4),
                TextTitle = textTitle
            };

            var resultViewModel = new TextWriteResultViewModel()
            {
                CurrentTextStatistics = textStatistics, 
                TextTitle = textTitle,
                TextSize = textSize,
                ViewTextTitle = textTitle.GetViewTextTitle(textSize)
            };

            if(signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                var bestStatistics = user.SetTextStatisticsAndGetBestStatistics(textSize, 
                    textStatistics);
                resultViewModel.BestTextStatistics = bestStatistics;
                var result = await userManager.UpdateAsync(user);
                if(!result.Succeeded)
                    resultViewModel.BestTextStatistics = null;

            }
            return View(resultViewModel);
        }
    }
}
