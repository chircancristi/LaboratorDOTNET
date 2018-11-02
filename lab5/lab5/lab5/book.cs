using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab5
{
    public class Book
    {
        int Id {
            set; get;
        }

        [Required][MaxLength(100)][MinLength(50)]
        string Title {
            set; get;
        }
    }
}
