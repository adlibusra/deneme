using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adaptors;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbuksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1993, 3, 13),
                FirstName = "Buşra",
                LastName = "Çalışkan",
                NationalityId = "31891170336"

                
            });
            Console.ReadLine();
        }
    }

 
}
