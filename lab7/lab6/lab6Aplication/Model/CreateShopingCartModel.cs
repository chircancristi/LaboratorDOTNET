using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab7Aplication.Model
{
    public class CreateShopingCartModel
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime date { get; set;  }
    }
}
