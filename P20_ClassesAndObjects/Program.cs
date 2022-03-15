namespace P20_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // <========== Book ==========>
            //
            // Book 1
            Book book1 = new Book();
            book1.title = "Harry Potter and the Cursed Child";
            book1.author = "J K Rowling";
            book1.pages = 439;
            Console.WriteLine(book1.title + " | " + book1.author + " | " + book1.pages);

            // Book 2
            Book book2 = new Book();
            book2.title = "Lord of the Rings - The return of the King";
            book2.author = "Tolkein";
            book2.pages = 942;
            Console.WriteLine(book2.title + " | " + book2.author + " | " + book2.pages);

            // Book 3
            Book book3 = new Book("Harry Potter and the Chambers of Secret", "J K Rowling", 758);
            Console.WriteLine(book3.title + " | " + book3.author + " | " + book3.pages);

            //
            // <========== Student ==========>
            //
            // Student 1
            Student student1 = new Student("Jim", "Business", 2.8);

            // Student 2
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.name + " has honours: " + student1.HasHonours());
            Console.WriteLine(student2.name + " has honours: " + student2.HasHonours());

            //
            // <========== Movie ==========>
            //
            // Movie 1
            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");

            // Movie 2
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "Dog");

            Console.WriteLine(movie1.title + " has rating " + movie1.Rating + ".");
            Console.WriteLine(movie2.title + " has rating " + movie2.Rating + ".");

            //
            // <========== Song ==========>
            //
            // Song 1
            Song song1 = new Song("Holiday", "Green Day", 200);
            Console.WriteLine("Added song: " + song1.title + " | Total songs till now: " + Song.songCount);

            // Song 2
            Song song2 = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine("Added song: " + song1.title + " | Total songs till now: " + Song.songCount);

            //
            // <========== UsefulTools ==========>
            //
            // Static methods
            Console.WriteLine("Sqrt of 144: " + Math.Sqrt(144));

            UsefulTools.SayHi("Dhrumil");
        }
    }
}