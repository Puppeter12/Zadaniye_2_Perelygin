using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniye_2_Perelygin
{
    public class StatisticsDigits
    {
         int number;
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
        public StatisticsDigits(int _number) 
        {
            number = _number;
        }
       public StatisticsDigits() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StatisticsDigits ex1 = new StatisticsDigits(542);
            ex1.Zchet();
        }
    }
}
