using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Course.src.helpers
{
    public class Utilities
    {
        public void TitleColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        public void PromptColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public void TipColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }

        public void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void ErrorColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

    }
}