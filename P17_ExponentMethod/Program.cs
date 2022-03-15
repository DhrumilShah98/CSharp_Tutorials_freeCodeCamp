namespace P17_ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetPow(2, 3): " + GetPow(2, 3));
            Console.WriteLine("GetPow(3, 5): " + GetPow(3, 5));
            Console.WriteLine("GetPow(4, 3): " + GetPow(4, 3));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i = 1; i <= powNum; ++i)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}