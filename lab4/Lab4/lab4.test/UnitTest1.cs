using System;
using Lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var employee = new Employee(1,"Gelu","Sandu",new DateTime(2008,11,11),new DateTime(2019,11,11),200);
            var customer = new Customer(2,"George", "Nelu","0743360421", "chircanRaw2008@yahoo.com");

            var employee2 = new Employee(3, "Gelu", "Sandu", new DateTime(2008, 11, 11), new DateTime(2019, 11, 11), 200);
            var customer2 = new Customer(4, "George", "Nelu", "0743360421", "chircanRaw2008@yahoo.com");
           
            var employee3 = new Employee(5, "Gelu", "Sandu", new DateTime(2008, 11, 11), new DateTime(2019, 11, 11), 200);
            var customer3 = new Customer(6, "George", "Nelu", "0743360421", "chircanRaw2008@yahoo.com");

            var employee4 = new Employee(7, "Gelu", "Sandu", new DateTime(2008, 11, 11), new DateTime(2019, 11, 11), 200);
            var customer4 = new Customer(9, "George", "Nelu", "0743360421", "chircanRaw2008@yahoo.com");



            CustomerRepository customerRepository = new CustomerRepository();
            EmployeeRepository employeeRepository = new Lab4.EmployeeRepository();

            customerRepository.Add(customer);
            customerRepository.Add(customer2);
            customerRepository.Add(customer3);
            customerRepository.Add(customer4);

            employeeRepository.Add(employee);
            employeeRepository.Add(employee2);
            employeeRepository.Add(employee3);
            employeeRepository.Add(employee4);


        }
    }
}
