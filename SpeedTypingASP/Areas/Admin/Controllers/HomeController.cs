using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpeedTypingASP.Domain;

namespace SpeedTypingASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AdminPanelInformation adminPanelInformation;
        public HomeController(DataManager dataManager, UserManager<UserInformation> userManager)
        {
            this.adminPanelInformation = new AdminPanelInformation(userManager, dataManager);
        }
        public IActionResult Index()
        {
            return View(adminPanelInformation);
        }
    }
}
