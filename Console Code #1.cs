using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Решение: Задание 1*************** ");
            Console.WriteLine("Введите числа");
            int DayInDate, MonthInDate, YearInDate, Visokos;
            string Correctly = "", FirstDay = "", LastDay = "";
            Console.Write("а=");
            DayInDate = Int32.Parse(Console.ReadLine());
            Console.Write("b=");
            MonthInDate = Int32.Parse(Console.ReadLine());
            Console.Write("c=");
            YearInDate = Int32.Parse(Console.ReadLine());

            if (((YearInDate % 4 == 0) & (YearInDate % 100 != 0)) | (YearInDate % 400 == 0))
            {
                Visokos = 1;
            }
            else
            {
                Visokos = 0;
            }

            if (YearInDate < 0)
            {
                Correctly = "Некорректно";
            }
            else
            {
                Int32 summ = 0;
                switch (MonthInDate)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (DayInDate <= 31)
                            Correctly = "Корректно";
                        else
                        {
                            Correctly = "Некорренктно";
                            break;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (DayInDate <= 30)
                            Correctly = "Корректно";
                        else
                        {
                            Correctly = "Некорректно";
                            break;
                        }
                        break;
                    case 2:
                        if (DayInDate <= (28 + Visokos))
                            Correctly = "Корректно";
                        else
                        {
                            Correctly = "Некорректно";
                            break;
                        }
                        break;
                    default:
                        Correctly = "Некорректно";
                        break;
                }
                switch (MonthInDate)
                {
                    case 1:
                        summ = summ + DayInDate;
                        break;
                    case 2:
                        summ = summ + 31;
                        goto case 1;
                    case 3:
                        summ = summ + 28 + Visokos;
                        goto case 2;
                    case 4:
                        summ = summ + 31;
                        goto case 3;
                    case 5:
                        summ = summ + 30;
                        goto case 4;
                    case 6:
                        summ = summ + 31;
                        goto case 5;
                    case 7:
                        summ = summ + 30;
                        goto case 6;
                    case 8:
                        summ = summ + 31;
                        goto case 7;
                    case 9:
                        summ = summ + 31;
                        goto case 8;
                    case 10:
                        summ = summ + 30;
                        goto case 9;
                    case 11:
                        summ = summ + 31;
                        goto case 10;
                    case 12:
                        summ = summ + 30;
                        goto case 11;

                }
                FirstDay = Convert.ToString(summ);
                LastDay = Convert.ToString(365 + Visokos - summ);
            }
            Console.WriteLine($"Корректность:{Correctly}, Номер дня:{FirstDay}, Дней до конца года:{LastDay}");
            Console.ReadLine();

        }
    }
}
