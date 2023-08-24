using System;

namespace CSharp_Course.src
{
    public class Shapes
    {
        public void Triangle()
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
        }

        public void Circle()
        {
            Console.WriteLine(" __");
            Console.WriteLine("/  \\");
            Console.WriteLine("\\__/");
        }

        public void Square()
        {
            Console.WriteLine("_____");
            Console.WriteLine("|   |");
            Console.WriteLine("|___|");
        }
    }
}