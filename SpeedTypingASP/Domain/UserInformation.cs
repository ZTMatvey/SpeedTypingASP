using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace SpeedTypingASP.Domain
{
    public class UserInformation : IdentityUser
    {
        private string JsonTextsStatistics { get; set; }

        public TextStatistics UpdateTextStatisticsAndGetBestStatistics(TextStatistics textStatistics)
        {
            var textsStatistics = JsonConvert.DeserializeObject<List<TextStatistics>>(JsonTextsStatistics ?? "") ?? new List<TextStatistics>();
            var currentTextStatistics = textsStatistics.FirstOrDefault(x => x.TextId == textStatistics.TextId);

            if (currentTextStatistics == null)
            {
                textsStatistics.Add(textStatistics);
                currentTextStatistics = textStatistics;
            }
            else
            {
                if (textStatistics.MaxCountOfCorrects > currentTextStatistics.MaxCountOfCorrects)
                    currentTextStatistics.MaxCountOfCorrects = textStatistics.MaxCountOfCorrects;
                if (textStatistics.MinCountOfErrors < currentTextStatistics.MinCountOfErrors)
                    currentTextStatistics.MinCountOfErrors = textStatistics.MinCountOfErrors;
                if (textStatistics.MinMiliseconds < currentTextStatistics.MinMiliseconds)
                    currentTextStatistics.MinMiliseconds = textStatistics.MinMiliseconds;
            }

            JsonTextsStatistics = JsonConvert.SerializeObject(textsStatistics);
            ApplicationDbContext.GetDbContext().SaveChanges();

            return currentTextStatistics;
        }
    }
}
