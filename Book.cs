namespace Week4_HomeWork
{
    public class Book
    {
        public string title;
        public string author;
        public int year;

        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string GetTitle()
        {
            return title;
            Console.WriteLine($"The book's title is {this.title}.");
        }
        public string GetAuthor()
        {
            return author;
            Console.WriteLine($"The book's author is {this.author}.");
        }

        public int GetYear()
        {
            return year;
            Console.WriteLine($"The year the book was published is {this.year}.");
        }

        public string SetTitle(string title)
        {
            this.title = title;
            return title;
        }

        public string SetAuthor(string author)
        {
            this.author = author;
            return author;
        }

        public int SetYear(int year)
        {
            this.year = year;
            return year;
        }
    }
}
