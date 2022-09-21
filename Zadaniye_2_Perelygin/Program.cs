using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniye_2_Perelygin
{
    class StatisticsDigits
    {
        public int number;
        public void Zchet() 
        {
            int i = 0;
            int del = 10;
            while (number > 0) 
            {
                int c = number % del;
                number /= del;
                i++;
                Console.WriteLine("{0}",c);
            }
            Console.WriteLine("Количество чисел в числе: {0}", i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StatisticsDigits ex1 = new StatisticsDigits();
            ex1.number = 64252;
            ex1.Zchet();
        }
    }
}
