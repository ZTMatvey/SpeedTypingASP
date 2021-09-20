using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpeedTypingASP.Domain.Repositories.Abstract;

namespace SpeedTypingASP.Domain.Repositories.EF
{
    public class EFStatisticTypeRepository: IStatisticTypeRepository
    {
        private readonly ApplicationDbContext context;
        public EFStatisticTypeRepository(ApplicationDbContext context) => this.context = context;
        public IQueryable<StatisticType> GetStatisticTypes() => context.StatisticTypes;

        public StatisticType GetStatisticTypeById(string id) => context.StatisticTypes.FirstOrDefault(x => x.Id == id);

        public void SaveStatisticType(StatisticType text)
        {
            if (text.Id == default)
            {
                text.Id = Guid.NewGuid().ToString();
                context.Entry(text).State = EntityState.Added;
            }
            else
                context.Entry(text).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteStatisticTypeById(string id)
        {
            context.StatisticTypes.Remove(new StatisticType { Id = id });
            context.SaveChanges();
        }
    }
}
