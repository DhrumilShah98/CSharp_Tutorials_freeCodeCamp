namespace P16_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GUESS_LIMIT = 5;
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            bool outOfGuesses = false;
            
            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < GUESS_LIMIT)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            } else
            {
                Console.WriteLine("You Win!");
            }
        }
    }
}