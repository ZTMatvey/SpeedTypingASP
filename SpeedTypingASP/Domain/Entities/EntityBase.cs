using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public string Id { get; set; }
    }
}
