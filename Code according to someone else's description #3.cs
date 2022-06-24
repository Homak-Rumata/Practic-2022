using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_по_схемам__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            Int32 n = Int32.Parse(Console.ReadLine());
            Console.Write("x = ");
            Int32 x = Int32.Parse(Console.ReadLine());

            Int32[] arr = new Int32[n];
            Random rnd = new Random();
            for (Int32 i = 0; i < n; i++)
            {
                arr[i] = rnd.Next();
            }
            for (Int32 i=0; i<n; i++)
            {
                if (arr[i]==x)
                {
                    Console.WriteLine("yes");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    
                }
            }
            Console.WriteLine("no");
            Console.ReadLine();
        }
    }
}
