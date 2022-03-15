namespace P12_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall.");
            }
            else
            {
                Console.WriteLine("You are not male and not tall.");
            }

            Console.WriteLine("GetMaxOf2(2, 3): " + GetMaxOf2(2, 3));
            Console.WriteLine("GetMaxOf2(10, 2): " + GetMaxOf2(10, 2));
            Console.WriteLine("GetMaxOf3(10, 20, 15): " + GetMaxOf3(10, 20, 15));
            Console.WriteLine("GetMaxOf3(10, 20, 25): " + GetMaxOf3(10, 20, 25));
        }

        static int GetMaxOf2(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }
            return result;
        }

        static int GetMaxOf3(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }
            return result;
        }
    }
}