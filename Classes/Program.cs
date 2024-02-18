using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            //set
            Customer customer = new Customer();
            customer.City = "Bartın";
            customer.Id = 1;
            customer.FirstName = "Burak";
            customer.LastName = "Cavus";

            //get
            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Faruk",
                LastName = "LittleBird",
                City = "Konya"
            };
            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();
        }
    }
}
