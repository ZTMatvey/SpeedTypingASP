using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpeedTypingASP.Domain.Entities;
using SpeedTypingASP.Domain.Repositories.Abstract;

namespace SpeedTypingASP.Domain.Repositories.EF
{
    public class EFTextRepository : ITextRepository
    {
        private readonly ApplicationDbContext context;
        public EFTextRepository(ApplicationDbContext context) => this.context = context;
        public IQueryable<Text> GetTexts() => context.Texts;

        public Text GetTextById(string id) => context.Texts.FirstOrDefault(x => x.Id == id);

        public void SaveText(Text text)
        {
            if (text.Id == default)
                context.Entry(text).State = EntityState.Added;
            else
                context.Entry(text).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTextById(string id)
        {
            context.Texts.Remove(new Text() { Id = id });
            context.SaveChanges();
        }
    }
}
