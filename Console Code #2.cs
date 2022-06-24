using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Решение: Задание 2*************** ");
            Console.WriteLine("Введите числа");
            int DayInDate, MonthInDate, YearInDate, Visokos;
            Int16 JulianDay = 0, JulianMonth = 0, JulianYear = 0;
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

            Int16 year = Convert.ToInt16(YearInDate), month = Convert.ToInt16(MonthInDate),
            counter = Convert.ToInt16(YearInDate / 100 - YearInDate / 400), day;
            if (DayInDate <= 3 & month == 1)
            {
                day = Convert.ToInt16(DayInDate + 29);
                month = 12;
                year = Convert.ToInt16(year - 1);
            }
            else
            {
                day = Convert.ToInt16(DayInDate - 2);
            }
        point1:
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    {
                        if ((day + counter) <= 31)
                        {
                            JulianDay = Convert.ToInt16(day + counter);
                            JulianMonth = month;
                            JulianYear = year;
                            break;
                        }
                        else
                        {
                            month += 1;
                            counter = Convert.ToInt16(counter - (31 - day));
                            day = 0;
                            goto point1;
                        }
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if ((day + counter) <= 30)
                        {
                            JulianDay = Convert.ToInt16(day + counter);
                            JulianMonth = month;
                            JulianYear = year;
                            break;
                        }
                        else
                        {
                            month += 1;
                            counter = Convert.ToInt16(counter - (30 - day));
                            day = 0;
                            goto point1;
                        }
                    }
                case 2:
                    {
                        if ((day + counter) <= (28 + Visokos))
                        {
                            JulianDay = Convert.ToInt16(day + counter);
                            JulianMonth = month;
                            JulianYear = year;
                            break;
                        }
                        else
                        {
                            Int32 VisokosYear;
                            if (((counter % 4 == 0) & (counter % 100 != 0)) | (counter % 400 == 0))
                            {
                                VisokosYear = 1;
                            }
                            else
                            {
                                VisokosYear = 0;
                            }
                            month += 1;
                            counter = Convert.ToInt16(counter - ((28 + VisokosYear) - day));
                            day = 0;
                            goto point1;
                        }
                    }
                case 12:
                    {
                        if ((day + counter) <= 31)
                        {
                            JulianDay = Convert.ToInt16(day + counter);
                            JulianMonth = month;
                            JulianYear = year;
                            break;
                        }
                        else
                        {
                            month = 1;
                            counter = Convert.ToInt16(counter - (31 - day));
                            year += 1;
                            day = 0;
                            goto point1;
                        }
                    }
            }
            Console.WriteLine($"{JulianDay}.{JulianMonth}.{JulianYear}");
            Console.ReadLine();
        }
    }
    
}
