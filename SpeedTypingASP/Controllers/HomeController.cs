using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Domain.Entities;

namespace SpeedTypingASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.Texts.GetTexts());
        }
        public IActionResult TextWrite(string textTitle)
        {
            var text = dataManager.Texts.GetTexts().FirstOrDefault(x=> x.Title == textTitle);
            return View(text);
        }
    }
}
