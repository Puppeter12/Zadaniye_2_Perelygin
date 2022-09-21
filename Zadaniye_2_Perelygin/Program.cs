using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniye_2_Perelygin
{
    public class StatisticsDigits
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
        public void Summa()
        {
            int a = 0;
            while (number > 0)
            {
                a += number % 10;
               number /= 10;
            }
            Console.WriteLine("Сумма цифр числа = {0}", a);
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
            StatisticsDigits ex1 = new StatisticsDigits(721);
            ex1.Summa();
        }
    }
}
