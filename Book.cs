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
        }
        public string GetAuthor()
        {
            return author;
        }

        public int GetYear()
        {
            return year;
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
