using System;

namespace ReferansTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int, decimal,float ,enum , boolean ,value types= değer tipler
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("sayi 1 : " + sayi1);

            //// arrays, class, ,nterface ... reference types --> heap te ve stack te tutuluyor.. 
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0]=1000;

            //Console.WriteLine("sayilar 1 : "+ sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
           // Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CrediCardNumber = "123456";

            Employee employee = new Employee();
            employee.EmployeeNumber = 25894;
            employee.FirstName = "Veli";
            


            Person person3 = customer;
            person3.FirstName = "Ahmet";



            //  Console.WriteLine(((Customer)person3).CrediCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            Console.ReadLine();
        }
    }
    // Base Sınıf
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CrediCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
