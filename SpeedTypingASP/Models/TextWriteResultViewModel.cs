using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedTypingASP.Domain;

namespace SpeedTypingASP.Models
{
    public class TextWriteResultViewModel
    {
        public TextStatistics BestTextStatistics { get; set; }
        public TextStatistics CurrentTextStatistics { get; set; }
        public string TextTitle { get; set; }
    }
}
