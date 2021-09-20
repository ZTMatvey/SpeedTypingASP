using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SpeedTypingASP.Domain.Repositories.EF;
using SpeedTypingASP.Service;

namespace SpeedTypingASP.Domain
{
    public class UserInformation : IdentityUser
    {
        public string NormalStatisticTypeId { get; set; }
        [ForeignKey("NormalStatisticTypeId")]
        public virtual StatisticType NormalStatisticType { get; set; }

        public TextStatistics ChangeStatisticTypeAndGetBest(
            DataManager dataManager,
            StatisticTypeViews statisticTypeViews, 
            int textSize,
            TextStatistics textStatistics)
        {
            NormalStatisticType ??= new StatisticType();
            switch (statisticTypeViews)
            {
                case StatisticTypeViews.Normal:
                    var bestStatistics = NormalStatisticType.SetTextStatisticsAndGetBestStatistics(textSize,
                        textStatistics);
                    dataManager.StatisticTypes.SaveStatisticType(NormalStatisticType);
                    return bestStatistics;
            }

            throw new Exception();
        }
    }
}
