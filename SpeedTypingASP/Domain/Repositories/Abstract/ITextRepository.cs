using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedTypingASP.Domain.Entities;

namespace SpeedTypingASP.Domain.Repositories.Abstract
{
    public interface ITextRepository
    {
        IQueryable<Text> GetTexts();
        Text GetTextById(string id);
        void SaveText(Text text);
        void DeleteTextById(string id);
    }
}
