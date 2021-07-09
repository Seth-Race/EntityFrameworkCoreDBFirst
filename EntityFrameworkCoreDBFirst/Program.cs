using EntityFrameworkCoreDBFirst.Controllers;
using EntityFrameworkCoreDBFirst.Models;
using System;
using System.Linq;

namespace EntityFrameworkCoreDBFirst {
    class Program {
        static void Main(string[] args) {


            var customersController = new CustomersController();
            var customers = customersController.GetAll();
            var customer = customersController.GetById(4);
            Console.WriteLine($"{customer.Id}|{customer.Name}|{customer.Sales}|{customer.State}");


          //  var rc = customersController.Delete(customer.Id);
           // Console.WriteLine($"Deleted : {rc.Name}");

           //foreach (var c in customers) {
           //   Console.WriteLine($"{c.Id}|{c.Name}|{c.Sales}|{c.State}");
           //}
           /*       this is the add
            * var newCust = new Customer() {
            *    Id = 0,
            *   Name = "Meijer",
            *   State = "Minnesota",
            *   Sales = 100000,
            *   Active = true
            *   }
            */
            //var rc = customersController.Add(newCust);
            //Console.WriteLine($"New Customer Added: {rc.Name}|{rc.State}");


        }
    }
}
