using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Course.src.commands
{
    public class Commands
    {
        helpers.Utilities utilities = new helpers.Utilities();

        public void DisplayTitle()
        {
            utilities.TitleColor();
            Console.WriteLine(@"
  _____  _  _       _____                          
 / ____|| || |_    / ____|                         
| |   |_  __  _|  | |     ___  _   _ _ __ ___  ___ 
| |    _| || |_   | |    / _ \| | | | '__/ __|/ _ \
| |___|_  __  _|  | |___| (_) | |_| | |  \__ \  __/
 \_____||_||_|     \_____\___/ \__,_|_|  |___/\___|
");
            utilities.ResetColor();
        }

        public void DefaultPrompt()
        {
            utilities.PromptColor();
            Console.WriteLine("\nWhich chapter would you like to view?");
            utilities.TipColor();
            Console.WriteLine("Tip: Type \"Help\" for usage instructions.");
            Console.WriteLine("Tip: Type \"Chapters\" to view the chapter list.\n");
            utilities.ResetColor();
        }

        public void ViewChapterList()
        {
            utilities.PromptColor();
            Console.WriteLine("----- CHAPTERS -----");
            Console.WriteLine(string.Join("\n", Program.chapterList) + "\n");
            utilities.ResetColor();
        }

        public void ViewHelp()
        {
            utilities.TipColor();
            Console.WriteLine("----- HELP -----\n");
            Console.WriteLine("----- CHAPTERS -----");
            Console.WriteLine("Type chapter <num>, the number of the chapter, or the title of the chapter.");
            Console.WriteLine("Example: \"Chapter 0\", '0', \"Shapes\"");
            Console.WriteLine("\n----- CREDITS -----");
            Console.WriteLine("Type \"credits\" or \"authors\" to view the authors of this program.");
            Console.WriteLine("\n----- END OF HELP -----");
            utilities.ResetColor();
        }

        public void ViewCredits()
        {
            utilities.TipColor();
            Console.WriteLine("----- CREDITS -----\n");
            Console.WriteLine("Programmer: Boden McHale | Website: bodenmchale.github.io");
            Console.WriteLine("Course Creator: Mike Dane | Website: www.giraffeacademy.com");
            Console.WriteLine("\n----- END OF CREDITS -----");
            utilities.ResetColor();
        }

        public void InvalidInput()
        {
            Console.Clear();
            utilities.ErrorColor();
            Console.WriteLine("Unknown input, please type \"Help\" for usage information.");
            utilities.ResetColor();
        }
    }
}