using System;
using System.Collections.Generic;


namespace lab5
{
    public class BookRepository : IDisposable
    {


        private readonly AplicationContext aplicationContext;
        public IEnumerable<Book> GetAuthors()
        {
            return null;
        }
        public BookRepository(AplicationContext aplicationContext)
        {
            this.aplicationContext = context;
        }
        public void Remove(Book book)
        {
            aplicationContext.Remove(book);
        }
        public void Add(Author author)
        {
            aplicationContext.Add(book);
        }

    }
}