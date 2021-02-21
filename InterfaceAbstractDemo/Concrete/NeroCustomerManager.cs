using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adaptors;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private MernisServiceAdapter mernisServiceAdapter;

        public NeroCustomerManager()
        {
        }

        public NeroCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            this.mernisServiceAdapter = mernisServiceAdapter;
        }
    }
}
