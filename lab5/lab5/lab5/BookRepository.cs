using System;
using System.Collections.Generic;


namespace lab5
{
    public interface AuthorRepository : IDisposable
    {
        
        private readonly AplicationContext aplicationContext;
        IEnumerable<Book> GetAuthors();
        public AuthorRepository(AplicationContext aplicationContext)
        {
            this.aplicationContext = aplicationContext;
        }
        public void Remove(Book book)
        {
            _dbSet.Remove(book);
        }
        public void Add(Author author)
        {
            _dbSet.Add(book);
        }

    }
}