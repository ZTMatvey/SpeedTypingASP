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

        public List<TextStatistics> GetTextsStatistics()
        {
            var textsStatistics = DeserializeTextStatisticsAndGetIt();
            return textsStatistics;
        }

        public TextStatistics SetTextStatisticsAndGetBestStatistics(TextStatistics textStatistics)
        {
            var textsStatistics = DeserializeTextStatisticsAndGetIt();
            var currentTextStatistics = textsStatistics.FirstOrDefault(x => x.TextId == textStatistics.TextId);

            if (currentTextStatistics == null)
            {
                textsStatistics.Add(textStatistics);
                currentTextStatistics = textStatistics;
            }
            else
            {
                if (string.IsNullOrEmpty(currentTextStatistics.TextTitle))
                    currentTextStatistics.TextTitle = textStatistics.TextTitle;
                if (textStatistics.CountOfCorrects > currentTextStatistics.CountOfCorrects)
                    currentTextStatistics.CountOfCorrects = textStatistics.CountOfCorrects;
                if (textStatistics.CountOfErrors < currentTextStatistics.CountOfErrors)
                    currentTextStatistics.CountOfErrors = textStatistics.CountOfErrors;
                if (textStatistics.Miliseconds < currentTextStatistics.Miliseconds)
                    currentTextStatistics.Miliseconds = textStatistics.Miliseconds;
                if (textStatistics.CharactersPerMinute > currentTextStatistics.CharactersPerMinute)
                    currentTextStatistics.CharactersPerMinute = textStatistics.CharactersPerMinute;
            }

            SerializeTextStatistics(textsStatistics);
            return currentTextStatistics;
        }

        public void RemoveTextStatisticsByName(string textTitle)
        {
            var textsStatistics = GetTextsStatistics();
            textsStatistics = textsStatistics.Where(x => x.TextTitle != textTitle).ToList();
            SerializeTextStatistics(textsStatistics);
        }
        private void SerializeTextStatistics(List<TextStatistics> textsStatistics)
        {
            JsonTextsStatistics = JsonConvert.SerializeObject(textsStatistics);
        }
        private List<TextStatistics> DeserializeTextStatisticsAndGetIt()
        {
            var textsStatistics = JsonConvert.DeserializeObject<List<TextStatistics>>(JsonTextsStatistics ?? "") ?? new List<TextStatistics>();
            return textsStatistics;
        }
    }
}
