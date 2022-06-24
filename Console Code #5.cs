using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное__5
{
    class Program
    {

        static Int64 Pow(int counter)
        {
            Int64 summ = 3;
            for (int i = 1; i < ((counter + 1) * 33); i++)
            {
                summ *= 11;
                summ = summ / 7;
            }
            return summ;
        }


        static Int64 Process(int min, int max, int i = 0)
        {
            Int64 Big = 0;
            while ((Big < min) | (Big > max))
            {
                Int64 Num1 = Convert.ToInt32(Math.Abs((Pow(i + min) % min) + min));
                Int64 Num2 = Convert.ToInt32((Pow(i + max) % max) + max);
                Big = Convert.ToInt64(Math.Sqrt(Num1 * Num2));
                i = +1;
            }
            return Big;

        }
        static void Main(string[] args)
        {
            Int32 Min, Max;
            Console.WriteLine("***************Решение: Задание 5***************");
            Console.Write("Введите числo\nНижний диапазон = ");
            Min = Int32.Parse(Console.ReadLine());
            Console.Write("Верхний диапазон = ");
            Max = Int32.Parse(Console.ReadLine());

            for (Int32 i = 0; i<100; i++ )
            {
                Console.WriteLine(Process(Min, Max, i));
            }
            Console.ReadLine();
        }
    }
}
