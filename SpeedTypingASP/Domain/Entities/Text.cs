using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SpeedTypingASP.Domain.Entities
{
    [Index(nameof(Title), IsUnique = true)]
    public class Text : EntityBase
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string TextContent { get; set; }
    }
}
