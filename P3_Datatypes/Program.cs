namespace P3_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to store a text.
            string phrase = "Giraffe Academy";

            // Variable to store a single character.
            char grade = 'A';

            // Variable to store a whole number.
            int age = 24;

            // Variable to store a decimal number. (float, double, decimal) Least to Most accurate.
            double gpa = 3.2;

            Console.WriteLine(phrase + " will make sure you get an " + grade + " before " + age + " with GPA above " + gpa + ".");

            // Variable to store true or false. (Kind of like yes or no)
            bool isGood = true;
            Console.WriteLine(phrase + " is a good institute: " + isGood);
        }
    }
}