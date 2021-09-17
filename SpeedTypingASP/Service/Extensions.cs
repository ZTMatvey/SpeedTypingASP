using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedTypingASP.Domain;
using SpeedTypingASP.Service.Errors;

namespace SpeedTypingASP.Service
{
    public static class Extensions
    {
        public static string CutController(this string str) => str.Replace("Controller", "");

        public static string GetViewTextTitle(this string textTitle, int textSize)
        {
            switch (textSize)
            {
                case 1:
                    textTitle += " {ultra short}";
                    break;
                case 2:
                    textTitle += " {short}";
                    break;
                case 3:
                    textTitle += " {medium}";
                    break;
                case 4:
                    textTitle += " {large}";
                    break;
                case 5:
                    textTitle += " {full}";
                    break;
            }

            return textTitle;
        }
        public static List<TextStatistics> SortBySize(this List<TextStatistics> list)
        {
            var resultArr = new TextStatistics[5];
            foreach (var element in list)
                for (int i = 0; i < NamesOfElements.TextSizes.Length; i++)
                    if (element.TextTitle == NamesOfElements.TextSizes[i])
                    {
                        resultArr[i] = element;
                        break;
                    }

            var result = resultArr.ToList();
            for (int i = 0; i < result.Count; i++)
                if (result[i] == null)
                    result.RemoveAt(i--);

            return result;
        }
        public static string GetTimeInNormalForm(this int Miliseconds)
        {
            var _seconds = Miliseconds / 100;
            var _minutes = _seconds / 60;
            _seconds %= 60;
            var _miliSecs = Miliseconds % 100;
            var _strSeconds = _seconds < 10 ? $"0{ _seconds}" : _seconds.ToString();
            var _strMiliSecs = _miliSecs < 10 ? $"0{ _miliSecs}" : _miliSecs.ToString();
            return $"{ _minutes}:{ _seconds}.{ _miliSecs}";
        }
        public static int GetIndexOfFirstElementWithStartCharacter(this string input, int startCharacter, params char[] elements)
        {
            for (var i = startCharacter; i < input.Length; i++)
                if (elements.Any(element => input[i] == element))
                    return i;
            throw new CoincidencesNotFoundException("Совпадения не найдены");
        }
    }
}
