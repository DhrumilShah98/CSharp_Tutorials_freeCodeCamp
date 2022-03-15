namespace P18_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D Array
            int[,] numberGrid = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Print 2D Array
            Console.WriteLine("numberGrid[0][2]: " + numberGrid[0, 2]);
            Console.WriteLine("numberGrid[2][1]: " + numberGrid[2, 1]);

            // Declare 2D Array
            int[,] myArray = new int[2, 3];
            int counter = 0;
            for(int i = 0; i < 2; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    myArray[i, j] = ++counter;
                }
            }

            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.WriteLine("numberGrid[" + i + "][" + j + "]: " + myArray[i, j]);
                }
            }

        }
    }
}