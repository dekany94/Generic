using System;
using System.Collections.Generic;

namespace generic
{
    public class Customer
    {
        public List<Customer> customerList { get; set; }

        public String Name { get; set; }
        public Int32 Age { get; set; }
        public String Address { get; set; }


        public Customer()
        {
        }

        public Customer[] FillList()
        {
            Customer c1 = new Customer
            {
                Name = "Customer1",
                Age = 1,
                Address = "address1"
            };

            Customer c2 = new Customer
            {
                Name = "Customer2",
                Age = 2,
                Address = "address2"
            };

            return new Customer[] { c1, c2 };
        }

        //we don't need this
        //public Customer(String name, Int32 age, String address)
        //{
        //    Name = name;
        //    Age = age;
        //    Address = address;
        //}
    }
}
