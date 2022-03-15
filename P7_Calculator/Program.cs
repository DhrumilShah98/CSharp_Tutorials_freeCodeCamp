namespace P7_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: Convert class to convert into numbers

            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Calculator to add two numbers
            double sumNum1Num2 = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sumNum1Num2);

        }
    }
}