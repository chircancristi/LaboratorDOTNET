using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    public class CustomerRepository
    {
        private readonly AplicationContext _context;

        public CustomerRepository()
        {
            _context = new AplicationContext();
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void remove(Customer customer)
        {
            this._context.Customers.Remove(this._context.Customers.First(t => t.Id == customer.Id));
            _context.SaveChanges();
        }
        public void Update(Customer customer)
        {
            var existingCustomer = this._context.Customers.First(t => t.Id == customer.Id);
            existingCustomer.Id = customer.Id;
            existingCustomer.Name = customer.Name;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
            existingCustomer.Address = customer.Address;
            existingCustomer.Email = customer.Email;
            _context.SaveChanges();
        }
        public Customer GetById(int id)
        {
            return this._context.Customers.First(t => t.Id == id);
        }
        public DbSet <Customer> getAll()
        {
            return this._context.Customers;
        }
        public DbSet<Customer> GetEmployeesByMail(string email)
        {
            int i;
            DbSet<Customer> returnList = null;
            for (i = 0; i < this._context.Customers.Count(); i++)
            {
                if  (email.Equals(this._context.Customers.ElementAt(i).Email))
                {
                    returnList.Add(this._context.Customers.ElementAt(i));
                }
            }
            return returnList;
        }

    }
}
