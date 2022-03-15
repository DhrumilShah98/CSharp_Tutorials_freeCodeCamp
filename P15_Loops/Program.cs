namespace P15_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            // Infinite loop example
            //
            /* index = 0;
            while(index < 10)
            {
                Console.WriteLine("Index: " + index);
            }*/

            //
            // while Loop
            //
            Console.WriteLine("=====> while() Loop <=====");
            int index = 1;
            while(index <= 10)
            {
                Console.WriteLine("Index: " + index);
                index++;
            }

            //
            // do-while Loop
            //
            Console.WriteLine("=====> do-while() Loop <===== ");
            index = 11;
            do
            {
                Console.WriteLine("Index: " + index);
                index++;
            }
            while(index <= 10);

            //
            // for loop
            //
            Console.WriteLine("=====> for() Loop <===== ");
            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("Index: " + i);
            }

            // 
            // Iterating an array
            // 
            Console.WriteLine("=====> Iterating an array <===== ");
            int[] luckyNumbers = { 3, 6, 9, 12, 15, 18 };
            for (int i = 0; i < luckyNumbers.Length; ++i)
            {
                Console.WriteLine("luckyNumbers[" + i + "]: " + luckyNumbers[i]);
            }
        }
    }
}