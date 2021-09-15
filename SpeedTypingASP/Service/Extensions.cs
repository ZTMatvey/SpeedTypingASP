using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTypingASP.Service
{
    public static class Extensions
    {
        public static string CutController(this string str) => str.Replace("Controller", "");

        public static string GetViewTextTitle(this string textTitle, int textSize)
        {
            switch (textSize)
            {
                case 1:
                    textTitle += " {ultra short}";
                    break;
                case 2:
                    textTitle += " {short}";
                    break;
                case 3:
                    textTitle += " {medium}";
                    break;
                case 4:
                    textTitle += " {large}";
                    break;
                case 5:
                    textTitle += " {full}";
                    break;
            }

            return textTitle;
        }
    }
}
