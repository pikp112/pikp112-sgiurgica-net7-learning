namespace Week5_OOP_Advanced
{
    public class Book
    {
        private int _currentPage = 1;
        public string Title { get; set; }
        public string Author { get; set; }
        private int PageCount { get; set; }  //the number of pages in the book
        private int CurrentPage
        {
            get
            {
                return _currentPage;
            }

            set
            {
                _currentPage = value;

            }
        }  //the current page that the reader is on

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }
        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetPageCount()
        {
            return PageCount;
        }
        public int GetCurrentPage()
        {
            return CurrentPage;
        }

        public int NextPage()
        {
            return CurrentPage++;
        }

        public int PreviousPage()
        {
            return CurrentPage--;
        }

    }
}
