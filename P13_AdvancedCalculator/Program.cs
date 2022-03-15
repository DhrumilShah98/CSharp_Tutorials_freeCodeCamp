namespace P13_AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            } 
            else if (op == "-")
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            } 
            else if (op == "*")
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            } 
            else if (op == "/")
            { 
                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            } 
            else if (op == "%")
            {
                Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
            } 
            else
            {
                Console.WriteLine("Invalid operator");
            }

        }
    }
}