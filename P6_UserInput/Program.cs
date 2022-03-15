namespace P5_WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input from user using Console.ReadLine()

            // Difference between WriteLine() and Write(). WriteLine() writes a line and go on to a new line while Write() stays on the same line.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! You are " + age);
        }
    }
}