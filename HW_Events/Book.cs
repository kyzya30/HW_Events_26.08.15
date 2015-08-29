namespace HW_Events
{
    class Book
    {
        private string _bookName;
        private string _authorName;
        private string _genre;

        public Book(string bookName, string authorName, string genre)
        {
            _bookName = bookName;
            _authorName = authorName;
            _genre = genre;
        }
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}
