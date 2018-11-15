using System;
using System.Collections.Generic;


namespace lab5
{
    public class BookRepository : IDisposable
    {
        private AplicationContext context;
        public IEnumerable<Author> GetAuthors()
        {
            return null;
        }
        public BookRepository(AplicationContext context)
        {
            this.context = context;
        }
        public void Remove(Author author)
        {
            aplicationContext.Remove(author);
        }
        public void Add(Author author)
        {
            aplicationContext.Add(author);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}