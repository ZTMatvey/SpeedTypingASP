using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Domain.Repositories.Abstract
{
    public interface IStatisticTypeRepository
    {
        IQueryable<StatisticType> GetStatisticTypes();
        StatisticType GetStatisticTypeById(string id);
        void SaveStatisticType(StatisticType text);
        void DeleteStatisticTypeById(string id);
    }
}
