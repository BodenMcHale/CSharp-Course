using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Course.src
{
    public class Program
    {
        public static string[] chapterList = {"Shapes", "Variables", "Data Types", "Working With Strings", "Working With Numbers", 
                                "Getting User Input", "Building a Calculator", "Building a MadLib", "Arrays", "Methods", 
                                "Return Statement", "If Statements", "If Statements Continued", "Building a Better Calculator", 
                                "Switch Statements", "While Loops", "Building a Guessing Game", "For Loops", "Building an Exponent Method", 
                                "2D Arrays", "Comments", "Exception Handling", "Classes & Objects", "Constructors", "Object Methods", 
                                "Getters & Setters", "Static Class Attributes", "Static Methods & Classes", "Inheritance"};


        static void Main(string[] args)
        {
            commands.Commands commands = new commands.Commands();

            // Declare each chapter class
            chapters.Shapes shapes = new chapters.Shapes();
            chapters.Variables variables = new chapters.Variables();

            

            // Prefix a chapter keyword and number to each lesson
            for (int i = 0; i < chapterList.Length; i++)
            {
                // Example: Chapter 0: Shapes
                chapterList[i] = "Chapter " + i + ": " + chapterList[i];
            }

            // Clear the initial console
            Console.Clear();

            // Display the title screen before first loop
            commands.DisplayTitle();

            // Core loop
            while(true)
            {
                commands.DefaultPrompt();

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
                            Console.WriteLine(string.Join("", chapterList[0]));
                            shapes.ShapesIntro();
                            shapes.Triangle();
                            shapes.Circle();
                            shapes.Square();
                            break;
                        case "VARIABLES":
                        case "CHAPTER 1":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[1]));
                            variables.Story();
                            break;
                        case "DATA TYPES":
                        case "CHAPTER 2":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[2]));
                            break;
                        case "WORKING WITH STRINGS":
                        case "CHAPTER 3":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[3]));
                            break;
                        case "WORKING WITH NUMBERS":
                        case "CHAPTER 4":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[4]));
                            break;
                        case "GETTING USER INPUT":
                        case "CHAPTER 5":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[5]));
                            break;
                        case "BUILDING A CALCULATOR":
                        case "CHAPTER 6":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[6]));
                            break;
                        case "BUILDING A MADLIB":
                        case "CHAPTER 7":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[7]));
                            break;
                        case "ARRAYS":
                        case "CHAPTER 8":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[8]));
                            break;
                        case "METHODS":
                        case "CHAPTER 9":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[9]));
                            break;
                        case "RETURN STATEMENT":
                        case "CHAPTER 10":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[10]));
                            break;
                        case "IF STATEMENTS":
                        case "CHAPTER 11":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[11]));
                            break;
                        case "IF STATEMENTS CONTINUED":
                        case "CHAPTER 12":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[12]));
                            break;
                        case "BUILDING A BETTER CALCULATOR":
                        case "CHAPTER 13":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[13]));
                            break;
                        case "SWITCH STATEMENTS":
                        case "CHAPTER 14":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[14]));
                            break;
                        case "WHILE LOOPS":
                        case "CHAPTER 15":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[15]));
                            break;
                        case "BUILDING A GUESSING GAME":
                        case "CHAPTER 16":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[16]));
                            break;
                        case "FOR LOOPS":
                        case "CHAPTER 17":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[17]));
                            break;
                        case "BUILDING AN EXPONENT METHOD":
                        case "CHAPTER 18":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[18]));
                            break;
                        case "2D ARRAYS":
                        case "CHAPTER 19":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[19]));
                            break;
                        case "COMMENTS":
                        case "CHAPTER 20":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[20]));
                            break;
                        case "EXCEPTION HANDLING":
                        case "CHAPTER 21":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[21]));
                            break;
                        case "CLASSES & OBJECTS":
                        case "CHAPTER 22":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[22]));
                            break;
                        case "CONSTRUCTORS":
                        case "CHAPTER 23":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[23]));
                            break;
                        case "OBJECT METHODS":
                        case "CHAPTER 24":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[24]));
                            break;
                        case "GETTERS & SETTERS":
                        case "CHAPTER 25":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[25]));
                            break;
                        case "STATIC CLASS ATTRIBUTES":
                        case "CHAPTER 26":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[26]));
                            break;
                        case "STATIC METHODS & CLASSES":
                        case "CHAPTER 27":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[28]));
                            variables.Story();
                            break;
                        case "INHERITANCE":
                        case "CHAPTER 28":
                            Console.Clear();
                            Console.WriteLine(string.Join("", chapterList[28]));
                            break;
                        case "CHAPTERS":
                        case "CHAPTER LIST":
                            Console.Clear();
                            commands.ViewChapterList();
                            break;
                        case "HELP":
                            Console.Clear();
                            commands.ViewHelp();
                            break;
                        case "CREDITS":
                        case "AUTHORS":
                            Console.Clear();
                            commands.ViewCredits();
                            break;
                        default:
                            commands.InvalidInput();
                            break;
                    }
                }
            }
        }
    }
}