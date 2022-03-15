namespace P2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // To change name of the person or age of the person, we need to search the whole story and find all
            // occurrences of name and age and then update it. (i.e., We need to change the name and age manually).
            // <===== Variables to rescue =====>

            // Variable is a container where we can hold a value and use it everywhere in the program. Just like below :)
            // Syntax: datatype variableName = variableValue;
            string storyCharacterName = "George"; // Variable to store a text.
            int storyCharacterAge = 70; // Variable to store a number.

            Console.WriteLine("There once was a man named " + storyCharacterName + ".");
            Console.WriteLine("He was " + storyCharacterAge + " years old.");

            storyCharacterName = "Mike";
            Console.WriteLine("He really liked the name " + storyCharacterName + ".");
            Console.WriteLine("But didn't like being " + storyCharacterAge + ".");
        }
    }
}