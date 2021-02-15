using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //Count : propperty
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);
            
            Console.ReadLine();

        }
    }
    class MyList<T> // Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList() // constructor
        {
            _array = new T[0]; // 0 elemanlı array
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i=0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }


        }

        private  int _count; // count yaptım 

        public  int Count 
        {
            get { return _array.Length; }
            
        }

    }

}

