using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
       

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To DB" );
        }
    }
}
