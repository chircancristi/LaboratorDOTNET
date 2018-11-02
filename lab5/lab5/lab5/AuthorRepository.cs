using System;
using System.Collections.Generic;


namespace lab5
{
    public interface AuthorRepository : IDisposable
    { 
        private readonly AplicationContext aplicationContext;
        IEnumerable<Author> GetAuthors();
		public AuthorRepository(AplicationContext aplicationContext)
        {
            this.aplicationContext = aplicationContext;
        }
        public void Remove(Author author)
        {
            _dbSet.Remove(author);
        }
        public void Add(Author author)
        {
            _dbSet.Addd(author);
        }

    }
}