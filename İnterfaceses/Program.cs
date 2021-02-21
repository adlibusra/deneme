using System;

namespace İnterfaceses
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                Adress = "Ankara",
                LastName = "Demiroğ"
            };
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Adlığ",
                Departmant = ""

            };
            manager.Add(student);
            manager.Add(customer);

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                 new OracleCustomerDal(),
                 new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();

            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add( new SqlServerCustomerDal());

            Console.ReadLine();
        }
    }
    interface IPerson
    {
         int Id { get; set; }
        string FirstName  { get; set; }
        string  LastName { get; set; }


    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    
    class Student : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person )
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
