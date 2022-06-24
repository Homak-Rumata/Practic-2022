using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_схемам__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a, b, c;
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = Int32.Parse(Console.ReadLine());

            if (a<b & b<c)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadLine();
        }
    }
}
