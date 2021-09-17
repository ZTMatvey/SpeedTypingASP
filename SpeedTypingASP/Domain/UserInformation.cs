using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SpeedTypingASP.Service;

namespace SpeedTypingASP.Domain
{
    public class UserInformation : IdentityUser
    {
        public string JsonTextsStatistics { get; set; }
        public int AllTimeMiliseconds { get; set; }
        public double AverageCPM 
        {
            get
            {
                var statistics = GetTextsStatistics();
                var sumOfCPM = 0d;
                foreach (var statistic in statistics)
                    sumOfCPM += statistic.CharactersPerMinute;
                return Math.Round(sumOfCPM / statistics.Count, 4);
            }
        }
        public List<TextStatistics> GetTextsStatistics()
        {
            var textsStatistics = DeserializeTextStatisticsAndGetIt();
            return textsStatistics;
        }

        public TextStatistics SetTextStatisticsAndGetBestStatistics(int textSize, TextStatistics textStatistics)
        {
            if(textStatistics.CharactersPerMinute >= 100)
                AllTimeMiliseconds += textStatistics.Miliseconds;
            var textsStatistics = DeserializeTextStatisticsAndGetIt();
            var textTitle = $"{textStatistics.TextTitle} {{{NamesOfElements.TextSizes[textSize - 1]}}}";
            textStatistics.TextTitle = textTitle;
            var currentTextStatistics = textsStatistics.FirstOrDefault(x => x.TextTitle == textStatistics.TextTitle);

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
