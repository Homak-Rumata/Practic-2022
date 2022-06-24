using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_схемам__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x = 1, s = 0;
            while (x != 0)
            {
                Console.Write("x = ");
                x = Int32.Parse(Console.ReadLine());
                s += x;
            }
            Console.WriteLine($"s = {s}");
            Console.ReadLine();
        }
    }
}
