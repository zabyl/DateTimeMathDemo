using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(20));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddMinutes(50));

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));


            Console.WriteLine(Math.Abs(-4));

            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(19.2)); //20
            Console.WriteLine(Math.Round(19.2)); //19
            Console.WriteLine(Math.Floor(19.8)); //19

            Console.WriteLine(Math.Min(12, 17));
            Console.WriteLine(Math.Max(12, 17));

            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Sqrt(121));
            Console.WriteLine(Math.Log(12));
            Console.WriteLine(Math.Log10(12));

        }
    }
}
