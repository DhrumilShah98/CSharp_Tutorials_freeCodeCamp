namespace P5_WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 8;

            // Addition
            int twoNumsAdd = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + ": " + twoNumsAdd);

            // Subtraction
            int twoNumsSub = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + ": " + twoNumsSub);

            // Multiplication
            int twoNumsMul = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + ": " + twoNumsMul);

            // Division
            int twoNumsDiv = num2 / num1;
            Console.WriteLine(num2 + " / " + num1 + ": " + twoNumsDiv);

            // Modulo/Remainder
            int twoNumsMod = num2 % num1;
            Console.WriteLine(num2 + " % " + num1 + ": " + twoNumsMod);

            // Mix operations
            int mix1 = (4 + 2) * 3;
            Console.WriteLine("(4 + 2) * 3: " + mix1);

            // Decimal number Addition
            double dNumAdd = 5.0 + 8.1;
            Console.WriteLine("5.0 + 8.1: " + dNumAdd);

            //Increment/Decrement
            int num = 8;
            Console.WriteLine("num: " + num);

            num++;
            Console.WriteLine("num++: " + num);

            num--;
            Console.WriteLine("num--: " + num);

            // Math library for all math related operations
            Console.WriteLine("Math.Abs(-40): " + Math.Abs(-40));
            Console.WriteLine("Math.Pow(3, 2): " + Math.Pow(3, 2));
            Console.WriteLine("Math.Pow(3.8, 2): " + Math.Pow(3.8, 2));
            Console.WriteLine("Math.Sqrt(36): " + Math.Sqrt(36));
            Console.WriteLine("Math.Max(36, 90): " + Math.Max(36, 90));
            Console.WriteLine("Math.Min(36, 90): " + Math.Min(36, 90));
            Console.WriteLine("Math.Round(4.3): " + Math.Round(4.3));
        }
    }
}