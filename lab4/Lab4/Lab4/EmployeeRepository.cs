using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    public class EmployeeRepository
    {
        private readonly AplicationContext _context;

        public EmployeeRepository()
        {
            this._context = new AplicationContext();
        }
        public void Add(Employee Employee)
        {
            this._context.Employees.Add(Employee);
            this._context.SaveChanges();
        }
        public void remove(Employee employee)
        {
            this._context.Employees.Remove(this._context.Employees.First(t => t.Id == employee.Id));
            _context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            var existingEmployee = this._context.Employees.First(t => t.Id == employee.Id);
            existingEmployee.Id= employee.Id;
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.EndDate = employee.EndDate;
            existingEmployee.StartDate = employee.StartDate;
            _context.SaveChanges();
        }
        public Employee GetById(int id)
        {
            return this._context.Employees.First(t => t.Id == id);
        }
        public DbSet<Employee> getAll()
        {
            return this._context.Employees;
        }
        public DbSet<Employee> GetEmployeesBySalary(int salary)
        {
            int i;
            DbSet<Employee> returnList=null;
            for (i=0;i<this._context.Employees.Count();i++)
            {
                if(salary==this._context.Employees.ElementAt(i).Salary)
                {
                    returnList.Add(this._context.Employees.ElementAt(i));
                }
            }
            return returnList;
        }

    }
}
