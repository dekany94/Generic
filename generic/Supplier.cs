using System;
using System.Collections.Generic;

namespace generic
{
    public class Supplier
    {
        public List<Supplier> supplierList { get; set; }

        public String Name { get; set; }
        public Int32 Age { get; set; }
        public String Address { get; set; }

        public Supplier()
        {
        }

        public Supplier[] FillList()
        {
            Supplier s1 = new Supplier
            {
                Name = "Supplier1",
                Age = 3,
                Address = "address3"
            };

            Supplier s2 = new Supplier
            {
                Name = "Supplier2",
                Age = 4,
                Address = "address4"
            };

            return new Supplier[] { s1, s2 };
        }

        public Supplier(String name, Int32 age, String address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
