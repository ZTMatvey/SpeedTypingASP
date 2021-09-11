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
        public int CountOfErrors { get; set; }
        public int CountOfCorrects { get; set; }
        public int Miliseconds { get; set; }
        public double CharactersPerMinute { get; set; }
    }
}
