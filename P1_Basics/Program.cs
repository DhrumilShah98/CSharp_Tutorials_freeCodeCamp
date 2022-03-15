/** 
 * 'namespace' is the same name of the project we are working with. (i.e., P1_Basics)
 * It is saying that we are in the P1_Basics project. 
 */
namespace P1_Basics
{
    /**
     * class is a container where we store a bunch of code.
     * Inside of a class, we write all of the code for our program which can be executed.
     */
    class Program
    {
        /**
         * method or function that contains logic to be executed.
         * Code inside the method will be executed.
         * 
         */
        static void Main(string[] args)
        {
            // This is essentially telling that I want to print something on the screen/console.
            // ';' ends the current line of code.
            Console.WriteLine("Hello World!");

            // This accepts a line of input from the screen/console.
            Console.ReadLine();

            // Draw a Pyramid
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
        }
    }
}