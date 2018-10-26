using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4
{
    public class Customer
    {
        public Customer(int id,string name,string address,string phoneNumber,string email)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public int Id
        {
            get;  set;
        }
         public string Name
        {
            get;  set;
        }
        public string Address
        {
            get;  set;
        }
        [RegularExpression("07[0-9]{8}")]
        public string PhoneNumber
        {
            get;  set;
        }
        [RegularExpression("[a-zA-Z0-9]+@[a-zA-Z]+\\.[a-zA-Z]+")]
        public string Email
        {
            get;  set;
        }
     
    
}
}
