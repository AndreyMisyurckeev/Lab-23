using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X для расчета факториала числа: ");
            long a = Convert.ToInt32(Console.ReadLine());
            long count = FactorialAsync(a).Result;
            Console.WriteLine($"Факториал числа равен: {count}");
            Console.ReadKey();
        }
        static long Factorial(long a)
        {
            long r = 1;
            if (a == 0)
                return 1;
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    r *= i;
                }
                return r;
            }
        }
        static async Task<long> FactorialAsync(long a)
        {
            long count = await Task.Run(() => Factorial(a));
            return count;
        }
    }
}

