using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 NumMax, NumCounter = 0, Max, Num;
            string Text = "";
            Console.WriteLine("***************Решение: Задание 4***************");
            Console.Write("Введите числo \nЧисло попыток=");
            Max = Int32.Parse(Console.ReadLine());
            Console.Write("Максимальное значение числа=");
            NumCounter = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            NumMax = rnd.Next(NumCounter);

            Text = Console.ReadLine();
            while (Int32.Parse(Text) != NumMax)
            {
                Max -= 1;
                if (Max != 0)
                {
                    if (Convert.ToInt32(Text) < NumMax)
                    {
                        Max -= 1;
                        Console.WriteLine("Больше");
                    }
                    else
                    {
                        Max -= 1;
                        Console.WriteLine("Меньше");
                    }
                }
                else
                {
                    Console.WriteLine("Попытки закончились");
                    Console.ReadLine();
                    goto exit;
                }
                Text = Console.ReadLine();
            }
            
            Console.WriteLine("Вы угадали!!!");
            exit:
            Console.ReadLine();
        }
    }
}
