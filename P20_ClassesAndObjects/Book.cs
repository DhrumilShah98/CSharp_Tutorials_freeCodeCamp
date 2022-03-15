namespace P20_ClassesAndObjects
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            title = "";
            author = "";
            pages = 0;
        }

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}