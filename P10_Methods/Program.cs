namespace P10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the method to execute
            SayHi();

            // Method with one argument
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            PrintAge(Convert.ToInt32(userAge));

            // Method with two arguments
            PrintNameAge("Aniket", 25);
        }

        /**
         * Method syntax
         * static return_type method_name() { ... }
         */
        static void SayHi()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
        }

        /**
         * Method syntax
         * static return_type method_name(datatype arg1) { ... }
         */
        static void PrintAge(int age)
        {
            Console.WriteLine("Age: " + age);
        }

        /**
         * Method syntax
         * static return_type method_name(datatype arg1, datatype arg2) { ... }
         */
        static void PrintNameAge(string name, int age)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }
    }
}