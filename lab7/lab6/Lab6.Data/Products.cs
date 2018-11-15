using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab7.Data
{
    public class Products
    {
        public Guid Id {  get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Pieces { get; private set; }
        [NotMapped]
        public int Total { get { return Price * Pieces; } }

        Products( string name, int price , int pieces)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Price = price;
            this.Pieces = pieces;
        }
    }
}
