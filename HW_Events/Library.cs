using System.Collections.Generic;

namespace HW_Events
{
    class Library
    {
        List<Book> lst = new List<Book>();
        public event ActionsWithBook addBook;
        public event ActionsWithBook removeBook;

        public void AddBook(Book book)
        {
            lst.Add(book);
            addBook(book);

        }

        public void RemoveBook(Book book)
        {
            lst.Remove(book);
            removeBook(book);
        }
    }
}
