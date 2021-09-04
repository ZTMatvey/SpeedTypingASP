using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Service
{
    public static class Extensions
    {
        public static string CutController(this string str) => str.Replace("Controller", "");
    }
}
