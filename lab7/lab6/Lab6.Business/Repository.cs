using Lab7.Data;
using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab7.Business
{
    public class Repository : ItRepository
    {
        private readonly DataContext _context;
        public Repository ( DataContext context)
        {
            _context = context;
        }
        public void Create(ShoppingCart shoppingCart)
        {
            _context.shoppingCarts.Add(shoppingCart);
            _context.SaveChanges();
        }
        public ShoppingCart GetById(Guid Id)
        {
            return _context.shoppingCarts.Find(Id);
        }
        public IReadOnlyList<ShoppingCart> GetAll()
        {
            return _context.shoppingCarts.ToList();
        }
    }
}
