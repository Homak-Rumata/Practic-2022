using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Решение: Задание 3***************");
            Console.WriteLine("Введите числo");
            int YearInProgram, Visokos;
            string[] Days = new string[12];
            Console.Write("Year=");
            YearInProgram = Int32.Parse(Console.ReadLine());

            if (((YearInProgram % 4 == 0) & (YearInProgram % 100 != 0)) | (YearInProgram % 400 == 0))
            {
                Visokos = 1;
            }
            else
            {
                Visokos = 0;
            }

            int i = 0;
            int N = 0;
            int c = 0;
        def:
            switch (i + 1)
            {
                case 1:
                    N = ((((365 * (YearInProgram-1)) + ((YearInProgram - 1) / 4) - ((YearInProgram - 1) / 100) + 5) % 7) + 31) % 7;
                    c = 31;
                    break;
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    N = ((N + 31) % 7);
                    c = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    N = ((N + 30) % 7);
                    c = 30;
                    break;
                case 2:
                    N = ((N + 28 + Visokos) % 7);
                    c = 28 + Visokos;
                    break;
                default:
                    N = 7;
                    break;
            }
            switch (N)
            {
                case 1:
                    Days[i] = Convert.ToString(c - 4) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 2:
                    Days[i] = Convert.ToString(c - 5) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 3:
                    Days[i] = Convert.ToString(c - 6) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 4:
                    Days[i] = Convert.ToString(c) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 5:
                    Days[i] = Convert.ToString(c - 1) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 6:
                    Days[i] = Convert.ToString(c - 2) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                case 0:
                    Days[i] = Convert.ToString(c - 3) + "." + Convert.ToString(i + 1) + "." + Convert.ToString(YearInProgram);
                    i += 1;
                    goto def;
                default:
                    break;
            }
            Console.WriteLine("\n");
            for (int CycleCounter = 0; CycleCounter<12; CycleCounter++)
            {
                Console.WriteLine(Days[CycleCounter]);
            }
            Console.ReadLine();
        }
    }
}
