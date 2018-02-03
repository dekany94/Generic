using System;
using System.Collections.Generic;

namespace generic
{
    //2018.01.03.
    //This Program use a generic method to write out two different list and its falues
    //keywords: #generic #reflection #ListInitializeWithArray
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Customer customer = new Customer();
                customer.customerList = new List<Customer>(customer.FillList());
             

                Supplier supplier = new Supplier();
                supplier.supplierList = new List<Supplier>(supplier.FillList());

                WriteList<Customer>(customer.customerList);
                Console.WriteLine("-----------------------------");
                WriteList<Supplier>(supplier.supplierList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void WriteList<T>(List<T> input)
        {
            var properties = GetProperties<T>();

            foreach (T item in input)
            {
                foreach (var prop in properties)
                {
                    var value = prop.GetValue(item, null);

                    Console.WriteLine("{0}: {1}", prop.Name, value);
                }
            }
        }

        private static System.Reflection.PropertyInfo[] GetProperties<T>()
        {
            //return obj.GetType().GetProperties();
            return typeof(T).GetProperties();
        }
    }
}
