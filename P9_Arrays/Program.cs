namespace P9_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays can store more than one value in a contagious memory block.

            // Array of integers (Way 1)
            // Most basic way to store values in an Array
            int[] luckyNumbers = { 3, 6, 9, 12, 15, 19};
            Console.WriteLine("luckyNumbers[0]: " + luckyNumbers[0]);
            Console.WriteLine("luckyNumbers[4]: " + luckyNumbers[4]);
            Console.WriteLine("luckyNumbers[5]: " + luckyNumbers[5]);

            // Update any value in an array
            luckyNumbers[5] = 18;
            Console.WriteLine("Updated luckyNumbers[5]: " + luckyNumbers[5]);

            // Array of strings (Way 2)
            // Define the size of the array first.
            string[] friends = new string[5];
            friends[0] = "Aniket";
            friends[1] = "Rishabh";
            Console.WriteLine("friends[0]: " + friends[0]);
        }
    }
}