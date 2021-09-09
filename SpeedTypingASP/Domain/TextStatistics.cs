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
        public int MinCountOfErrors { get; set; }
        public int MaxCountOfCorrects { get; set; }
        public int MinMiliseconds { get; set; }
    }
}
