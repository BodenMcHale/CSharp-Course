namespace Learning_CSharp.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            Variables variables = new Variables();

            string[] lessons = {"Shapes", "Variables"};

            while(true)
            {
                Console.WriteLine("Which lesson would you like to see?");
                Console.WriteLine(lessons.ToString());

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "SHAPES":
                        Console.WriteLine("Shapes!");
                        shapes.Triangle();
                        shapes.Circle();
                        shapes.Square();
                        break;
                    case "VARIABLES":
                        Console.WriteLine("Variables!");
                        variables.Story();
                        break;
                    case null:
                        Console.WriteLine("Unknown choice, please try another.");
                        break;
                    default:
                        Console.WriteLine("Unknown choice, please try another.");
                        break;
                }

            }
        }
    }
}