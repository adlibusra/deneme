using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
   public  interface IcustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
