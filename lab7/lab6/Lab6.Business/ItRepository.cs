using Lab7.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Business
{
    public interface ItRepository 
    {
        void Create(ShoppingCart shoppingCart);
        IReadOnlyList<ShoppingCart> GetAll();
        ShoppingCart GetById(Guid id);
    }
}
