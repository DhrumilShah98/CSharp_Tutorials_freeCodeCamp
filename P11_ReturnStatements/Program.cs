namespace P11_ReturnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeOf5 = Cube(5);
            Console.WriteLine("Cube of 5: " + cubeOf5);

            Console.WriteLine("Cube of 9: " + Cube(9));
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
            
            // or
            // return num * num * num;
        }
    }
}