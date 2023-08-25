using System;

namespace CSharp_Course.src
{
    public class Shapes
    {
        public void ShapesIntro()
        {
            Console.WriteLine("In this chapter the instructor covers using \"Console.WriteLine(\"\");\" to print shapes to the console.\n");
        }

        public void Triangle()
        {
            Console.WriteLine("Triangle: \n");
            Console.WriteLine("   /|\\");
            Console.WriteLine("  / | \\");
            Console.WriteLine(" /  |  \\");
            Console.WriteLine("/___|___\\");
        }

        public void Circle()
        {
            Console.WriteLine("Circle: \n");
            Console.WriteLine(" __");
            Console.WriteLine("/  \\");
            Console.WriteLine("\\__/");
        }

        public void Square()
        {
            Console.WriteLine("Square: \n");
            Console.WriteLine("_____");
            Console.WriteLine("|   |");
            Console.WriteLine("|___|");
        }
    }
}