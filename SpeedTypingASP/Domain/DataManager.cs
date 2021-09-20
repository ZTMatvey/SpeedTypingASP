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
        public readonly IStatisticTypeRepository StatisticTypes;

        public DataManager(ITextRepository texts, IStatisticTypeRepository statisticTypes)
        {
            Texts = texts;
            StatisticTypes = statisticTypes;
        }
    }
}
