using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SpeedTypingASP.Domain
{
    public class UserInformation : IdentityUser
    {
        public string JsonTextsStatistics { get; set; }

        public TextStatistics SetTextStatisticsAndGetBestStatistics(TextStatistics textStatistics)
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
                if (textStatistics.CountOfCorrects > currentTextStatistics.CountOfCorrects)
                    currentTextStatistics.CountOfCorrects = textStatistics.CountOfCorrects;
                if (textStatistics.CountOfErrors < currentTextStatistics.CountOfErrors)
                    currentTextStatistics.CountOfErrors = textStatistics.CountOfErrors;
                if (textStatistics.Miliseconds < currentTextStatistics.Miliseconds)
                    currentTextStatistics.Miliseconds = textStatistics.Miliseconds;
                if (textStatistics.CharactersPerMinute > currentTextStatistics.CharactersPerMinute)
                    currentTextStatistics.CharactersPerMinute = textStatistics.CharactersPerMinute;
            }

            JsonTextsStatistics = JsonConvert.SerializeObject(textsStatistics);
            return currentTextStatistics;
        }
    }
}
