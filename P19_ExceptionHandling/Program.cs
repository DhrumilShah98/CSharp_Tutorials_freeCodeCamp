namespace P19_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 + "/" + num2 + " = " + (num1/num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception - custom.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception - custom.");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error performing division.");
                Console.WriteLine(ex.Message);
            } 
            finally
            {
                Console.WriteLine("I am eternal!");
            }
        }
    }
}