using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace lab5
{
    public class Author
    {
            public Author(int id, string FirstName,string LastName)
        {
            //defensive codeing to be continued
            this.Id = id;
            if (FirstName.Length<100 && FirstName.Length>50 ){
                    this.FirstName=FirstName;
                }
            if (LastName<150){
                    this.LastName=LastName;
                }                            
        }
        public List<Book> Books= new List<Book>();
        public int Id
        {
            get; private set;
        }
        [Required][MaxLength(100)][MinLength(50)]
        public String FirstName
        {
            get;private set;
        }
        [Required][MaxLength(150)]
        public String LastName
        {
            get; private set;
        }
        public void add (Book book){  
            for (int i=0;i<=Books.Count;i++){
                        if (Books[i].Id==book.Id) throw Exception("There already exists a book with the given id");
                }
            Books.Add(book);
        }
        public void remove (Book book){
            for (int i=0;i<=Books.Count;i++){
                    if (Books[i].Id==book.Id) Books.Remove(book);
            }
            throw Exception("There is no such book in the list");
        }
        public void update (Book book,int index){
            if (index>=Books.Count) {
                    throw Exception("The index given is bigger than the number of elements");    
                }
            Books[index]=book;
        }
    }
}
