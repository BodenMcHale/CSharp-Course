using System;

namespace Drawing_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle();
            Circle();
            Square();

            Console.ReadLine();
        }

        static void Triangle()
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
        }

        static void Circle()
        {
            Console.WriteLine(" __");
            Console.WriteLine("/  \\");
            Console.WriteLine("\\__/");
        }

        static void Square()
        {
            Console.WriteLine("_____");
            Console.WriteLine("|   |");
            Console.WriteLine("|___|");
        }
    }
}