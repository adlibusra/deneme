using System;

namespace Interfaceses
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface new lenemez 
            
          

            CustomeManager ccutomerManager = new CustomeManager(); // interface referans tip : onu implemente eden clasın referans nosunu tutabilir  
          
            IPersonManager emloyeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.AddCustomer(customerManager);
           

            



        }
    }

    interface IPersonManager  // unimplemented opration // dışardan erişilebilir olur için doldurmuyoruz.. 

        
    { 
        void Add();
        void Update();
    }

    // inherits-class -------- interface- implements
    class CustomeManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri Ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Eklendi");
            
        }
    class ProjectManager
        {
            public void AddCustomer(CustomeManager customeManager)
            {
               
                customeManager.Add();

            }
            public void AddEmployee(EmployeeManager employeeManager)
            {

                employeeManager.Add();
            }
        }
        
    }


    //class PersonManager
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");    // içini dolduruyoruz implemente ediyoruz...inter face de unimplemente ediyoruz
    //    }

    //}
    //class CustomerManager: PersonManager
    //{

    //}
}
