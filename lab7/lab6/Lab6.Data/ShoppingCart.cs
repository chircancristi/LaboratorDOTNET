using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Lab7.Data
{
    public class ShoppingCart
    {
        public Guid Id { get; private set;}
        public DateTime Date { get; private set; }
        public string Description { get; private set;}
        [NotMapped]
        public int Total { get; set;}
        ICollection<Products> ProductsInCart;
        public ShoppingCart (DateTime date,string description)
        {
            Id = Guid.NewGuid();
            Date = date;
            Description = description;
            ProductsInCart = new List<Products>();
        }
        public void AddProduct(Products product)
        {
            ProductsInCart.Add(product);
        }
        public void RemoveProduct(Guid id)
        {
            var product = ProductsInCart.FirstOrDefault(b => b.Id == id);
            ProductsInCart.Remove(product);
        }
    }
}
