﻿using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //var result =Add2(20);

            // int number1 = 20;
            // int number2 = 100;
            /* var result2 = Add3(out number1, number2);
               Console.WriteLine(result2);
               Console.WriteLine( number1);
              // Console.WriteLine(result);*/

            //Console.WriteLine(Multiply(2, 4));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();

            
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2( int number1=30,int number2=10)
        {
            var result =  number1 + number2;
            return result;

        }
        static int Add3(out int number1, int number2)
        {
            number1= 30;
            var result2=  number1 + number2;

            return result2;
        }
        static int Multiply(int number1, int number2 = 30)
        {
            return number1 * number2;
        }
      

    }
}
