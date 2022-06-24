using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_схемам__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x, p;
            Double v;
            Console.Write("х = ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("p = ");
            p = Int32.Parse(Console.ReadLine());
            v = x * p * 0.001;
            Console.WriteLine($"v = {v}");
            Console.ReadLine();
        }
    }
}
