using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {

       // public string FirstName; // Field Alan değişken tanımlamak

        // property tanımalama Alan özellkleri get :ver , Set : ata
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mrs. " + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public String LastName { get; set; }
        public string City { get; set; }
    }
}
