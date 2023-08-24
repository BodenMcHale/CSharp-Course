namespace Learning_CSharp.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            Variables variables = new Variables();

            string[] lessons = {"Shapes", "Variables", "Data Types", "Working With Strings", "Working With Numbers", 
                                "Getting User Input", "Building a Calculator", "Building a MadLib", "Arrays", "Methods", 
                                "Return Statement", "If Statement", "If Statements Continued", "Building a Better Calculator", 
                                "Switch Statements", "While Loops", "Building a Guessing Game", "For Loops", "Building an Exponent Method", 
                                "2D Arrays", "Comments", "Exception Handling", "Classes & Objects", "Constructors", "Object Methods", 
                                "Getters & Setters", "Static Class Attributes", "Static Methods & Classes", "Inheritance"};

            while(true)
            {
                Console.WriteLine("Which lesson would you like to see?");
                Console.WriteLine(string.Join(", ", lessons));

                // Retrieve user input
                string? input = Console.ReadLine();

                if (input is not null)
                {
                    switch (input.ToUpper())
                    {
                        case "SHAPES":
                            Console.WriteLine("Chapter 1: Shapes");
                            shapes.Triangle();
                            shapes.Circle();
                            shapes.Square();
                            break;
                        case "VARIABLES":
                            Console.WriteLine("Chapter 2: Shapes");
                            variables.Story();
                            break;
                        default:
                            Console.WriteLine("Unknown choice \"" + input + "\", please try another.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown choice \"" + input + "\", please try another.");
                    break;
                }
            }
        }
    }
}