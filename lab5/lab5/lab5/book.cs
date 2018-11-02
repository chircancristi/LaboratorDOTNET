using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace lab5
{
    public class Book
    {
        [ForeignKey("AuthorForeignKey")]
        public Author Author {get;set;}
        public int AuthorId;
        public int Id {
         set;get;
        }
        [Required][MinLength(50)][MaxLength(50)]
        public string Title{
         set;get;
        }
    }
}
