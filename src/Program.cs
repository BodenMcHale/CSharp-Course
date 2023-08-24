using System;

namespace CSharp_Course.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare each chapter class
            Shapes shapes = new Shapes();
            Variables variables = new Variables();

            string[] chapters = {"Shapes", "Variables", "Data Types", "Working With Strings", "Working With Numbers", 
                                "Getting User Input", "Building a Calculator", "Building a MadLib", "Arrays", "Methods", 
                                "Return Statement", "If Statements", "If Statements Continued", "Building a Better Calculator", 
                                "Switch Statements", "While Loops", "Building a Guessing Game", "For Loops", "Building an Exponent Method", 
                                "2D Arrays", "Comments", "Exception Handling", "Classes & Objects", "Constructors", "Object Methods", 
                                "Getters & Setters", "Static Class Attributes", "Static Methods & Classes", "Inheritance"};

            // Prefix a chapter keyword and number to each lesson
            for (int i = 0; i < chapters.Length; i++)
            {
                // Example: Chapter 0: Shapes
                chapters[i] = "Chapter " + i + ": " + chapters[i];
            }

            // Clear the initial console
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // Display the title
            Console.WriteLine(@"
  _____  _  _      _____                          
 / ____|| || |_   / ____|                         
| |   |_  __  _| | |     ___  _   _ _ __ ___  ___ 
| |    _| || |_  | |    / _ \| | | | '__/ __|/ _ \
| |___|_  __  _| | |___| (_) | |_| | |  \__ \  __/
 \_____||_||_|    \_____\___/ \__,_|_|  |___/\___|
");

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nWhich lesson would you like to view?");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Tip: Type \"Help\" for usage instructions.\n");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("----- CHAPTERS -----");
                Console.WriteLine(string.Join("\n", chapters) + "\n");

                // Reset the console color to default
                Console.ForegroundColor = ConsoleColor.Gray;

                // Retrieve user input
                string? input = Console.ReadLine();

                if (input is not null)
                {
                    switch (input.ToUpper())
                    {
                        // Stack cases to mimic "or"
                        case "SHAPES":
                        case "CHAPTER 0":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[0]));
                            shapes.Triangle();
                            shapes.Circle();
                            shapes.Square();
                            break;
                        case "VARIABLES":
                        case "CHAPTER 1":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[1]));
                            variables.Story();
                            break;
                        case "DATA TYPES":
                        case "CHAPTER 2":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[2]));
                            break;
                        case "WORKING WITH STRINGS":
                        case "CHAPTER 3":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[3]));
                            break;
                        case "WORKING WITH NUMBERS":
                        case "CHAPTER 4":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[4]));
                            break;
                        case "GETTING USER INPUT":
                        case "CHAPTER 5":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[5]));
                            break;
                        case "BUILDING A CALCULATOR":
                        case "CHAPTER 6":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[6]));
                            break;
                        case "BUILDING A MADLIB":
                        case "CHAPTER 7":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[7]));
                            break;
                        case "ARRAYS":
                        case "CHAPTER 8":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[8]));
                            break;
                        case "METHODS":
                        case "CHAPTER 9":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[9]));
                            break;
                        case "RETURN STATEMENT":
                        case "CHAPTER 10":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[10]));
                            break;
                        case "IF STATEMENTS":
                        case "CHAPTER 11":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[11]));
                            break;
                        case "IF STATEMENTS CONTINUED":
                        case "CHAPTER 12":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[12]));
                            break;
                        case "BUILDING A BETTER CALCULATOR":
                        case "CHAPTER 13":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[13]));
                            break;
                        case "SWITCH STATEMENTS":
                        case "CHAPTER 14":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[14]));
                            break;
                        case "WHILE LOOPS":
                        case "CHAPTER 15":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[15]));
                            break;
                        case "BUILDING A GUESSING GAME":
                        case "CHAPTER 16":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[16]));
                            break;
                        case "FOR LOOPS":
                        case "CHAPTER 17":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[17]));
                            break;
                        case "BUILDING AN EXPONENT METHOD":
                        case "CHAPTER 18":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[18]));
                            break;
                        case "2D ARRAYS":
                        case "CHAPTER 19":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[19]));
                            break;
                        case "COMMENTS":
                        case "CHAPTER 20":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[20]));
                            break;
                        case "EXCEPTION HANDLING":
                        case "CHAPTER 21":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[21]));
                            break;
                        case "CLASSES & OBJECTS":
                        case "CHAPTER 22":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[22]));
                            break;
                        case "CONSTRUCTORS":
                        case "CHAPTER 23":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[23]));
                            break;
                        case "OBJECT METHODS":
                        case "CHAPTER 24":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[24]));
                            break;
                        case "GETTERS & SETTERS":
                        case "CHAPTER 25":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[25]));
                            break;
                        case "STATIC CLASS ATTRIBUTES":
                        case "CHAPTER 26":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[26]));
                            break;
                        case "STATIC METHODS & CLASSES":
                        case "CHAPTER 27":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[28]));
                            variables.Story();
                            break;
                        case "INHERITANCE":
                        case "CHAPTER 28":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapters[28]));
                            break;
                        case "HELP":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----- HELP -----\n");
                            Console.WriteLine("----- CHAPTERS -----");
                            Console.WriteLine("Type chapter <num>, the number of the chapter, or the title of the chapter.");
                            Console.WriteLine("Example: \"Chapter 0\", '0', \"Shapes\"");
                            Console.WriteLine("\n----- CREDITS -----");
                            Console.WriteLine("Type \"credits\" or \"authors\" to view the authors of this program.");
                            Console.WriteLine("\n----- END OF HELP -----");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case "CREDITS":
                        case "AUTHORS":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----- CREDITS -----\n");
                            Console.WriteLine("Programmer: Boden McHale | Website: bodenmchale.github.io");
                            Console.WriteLine("Course Creator: Mike Dane | Website: www.giraffeacademy.com");
                            Console.WriteLine("\n----- END OF CREDITS -----");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unknown input \"" + input + "\", please type \"Help\" for usage information.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                }
            }
        }
    }
}