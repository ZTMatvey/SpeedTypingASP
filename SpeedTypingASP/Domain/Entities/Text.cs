using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Domain.Entities
{
    public class Text : EntityBase
    {
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Виды текста")]
        public string TextContent { get; set; }
    }
}
