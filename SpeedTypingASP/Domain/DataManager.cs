using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedTypingASP.Domain.Repositories.Abstract;

namespace SpeedTypingASP.Domain
{
    public class DataManager
    {
        public readonly ITextRepository Texts;

        public DataManager(ITextRepository texts)
        {
            Texts = texts;
        }
    }
}
