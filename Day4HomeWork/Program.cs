using System;

namespace Day4HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionary<string> sehirler = new Mydictionary<string>();
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count);

            foreach (var sehir in sehirler.Items)
            {
                Console.WriteLine(sehir);
             
            }
            Console.ReadLine();
        }
    }
    class Mydictionary<T>
    {
        T[] _array;
        T[] _tempArray;
        public Mydictionary()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;

            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get { return _array; }
        }
        
    }
   
}
