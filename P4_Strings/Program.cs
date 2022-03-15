namespace P4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // '\n' - For line break.
            Console.WriteLine("Giraffe\nAcademy");

            // To print quotation mark (").
            Console.WriteLine("\"Giraffe Academy\"");

            // Concatenation (i.e., Use + operator).
            string academy = "Giraffe Academy" + " " + "is Cool";
            Console.WriteLine(academy);

            // Length of string (i.e., Use Length property).
            Console.WriteLine("Length: " + academy.Length);

            // To uppercase (i.e., ToUpper() method).
            Console.WriteLine(academy.ToUpper());

            // To lowercase (i.e. ToLower() method).
            Console.WriteLine(academy.ToLower());

            // Check for characters in string (i.e., Contains() method).
            Console.WriteLine(academy.Contains("Academy"));

            // To print character of string using index. (i.e., using [index]).
            // String indexing starts from 0.
            Console.WriteLine(academy[0]);

            // To get index of any character or sub-string (i.e., IndexOf() method). Returns -1 if character or sub-string not present.
            Console.WriteLine(academy.IndexOf("Academy"));

            // To get a sub-string from a string (i.e., Substring() method).
            Console.WriteLine(academy.Substring(8));
            Console.WriteLine(academy.Substring(8, 7));
        }
    }
}