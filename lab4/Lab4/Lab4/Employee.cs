using System;
using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, DateTime startDate, Nullable<DateTime> endDate, double salary)
        {
            //defensive codeing to be continued
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Salary = salary;
        }
       
        public int Id
        {
            get;  set;
        }
        [Required]
        [StringLength(50)]
        public string FirstName
        {
            get;  set;
        }
        [Required]
        [StringLength(70)]
        public string LastName
        {
            get;  set;
        }
        [Required]
        public DateTime StartDate
        {
            get;  set;
        }
        
        public Nullable <DateTime> EndDate
        {
            get;  set;
        }

        public double Salary
        {
            get;  set;
        }
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public bool IsActive()
        {
            if (this.StartDate > this.EndDate)
            {
                return false;
            }

            if (this.EndDate < DateTime.Now)
            {
                return false;
            }

            return true;
        }

        
    }
}
