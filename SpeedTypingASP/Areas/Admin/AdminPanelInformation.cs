using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Domain.Entities;

namespace SpeedTypingASP.Areas.Admin
{
    public class AdminPanelInformation
    {
        private readonly UserManager<UserInformation> userManager;
        private readonly DataManager dataManager;
        public AdminPanelInformation(UserManager<UserInformation> userManager, DataManager dataManager)
        {
            this.userManager = userManager;
            this.dataManager = dataManager;
        }

        public IQueryable<Text> GetTexts()=> dataManager.Texts.GetTexts();

        public List<UserInformation> GetUsers()
        {
            return userManager.Users.ToList();
        }
    }
}
