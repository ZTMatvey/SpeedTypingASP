using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }
        [Required]
        [UIHint("password")]
        public string ConfirmedPassword { get; set; }
    }
}
