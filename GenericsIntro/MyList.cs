using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[2]; // constructor array new lendiğinde çalışan blok// referans tip 
        }
        public void Add(T item)
        {
            T[] tempArray = items; // referans numarası uçmasın diye geçici diziye sabitledim.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
