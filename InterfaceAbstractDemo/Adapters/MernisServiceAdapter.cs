using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;

namespace InterfaceAbstractDemo.Adaptors
{
    class MernisServiceAdapter : IcustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(), customer.LastName.ToUpper(),customer.DateOfBirth.Year);

        }
    }
}
