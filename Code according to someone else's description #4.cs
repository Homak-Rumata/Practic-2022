using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_схемам__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x, m = 0, c = 0;
            Console.Write("x = ");
            x = Int32.Parse(Console.ReadLine());
            while (x > 0)
            {
                m = x % 10;
                x = x / 10;
                if (m % 2 == 0)
                {
                    c = c + m;
                }
                else
                {

                }
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}