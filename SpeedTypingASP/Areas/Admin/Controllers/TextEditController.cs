using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Domain.Entities;
using SpeedTypingASP.Service;

namespace SpeedTypingASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextEditController : Controller
    {
        private readonly DataManager dataManager;

        public TextEditController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(string textName)
        {
            var entity = dataManager.Texts.GetTextByName(textName);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Text model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Texts.SaveText(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        public IActionResult Add()
        {
            return View(new Text(){Id = Guid.NewGuid().ToString()});
        }
        [HttpPost]
        public IActionResult Add(Text model)
        {
            if (ModelState.IsValid)
            {
                model.Id = default;
                dataManager.Texts.SaveText(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        public IActionResult Delete(string textName)
        {
            dataManager.Texts.DeleteTextByName(textName);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
