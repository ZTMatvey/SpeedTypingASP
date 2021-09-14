using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedTypingASP.Domain.Entities;

namespace SpeedTypingASP.Domain
{
    public class TextStatistics
    {
        public string TextId { get; set; }
        public string TextTitle { get; set; }
        public int CountOfErrors { get; set; }
        public int CountOfCorrects { get; set; }
        public int Miliseconds { get; set; }
        public double CharactersPerMinute { get; set; }

        public string GetTimeInNormalForm()
        {
            var _seconds = Miliseconds / 100;
            var _minutes = _seconds / 60;
            _seconds %= 60;
            var _miliSecs = Miliseconds % 100;
            var _strSeconds = _seconds < 10 ? $"0{ _seconds}" : _seconds.ToString();
            var _strMiliSecs = _miliSecs < 10 ? $"0{ _miliSecs}" : _miliSecs.ToString();
            return $"{ _minutes}:{ _seconds}.{ _miliSecs}";
        }
    }
}
