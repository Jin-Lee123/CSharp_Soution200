using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A086_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime chrismas = new DateTime(2018, 12, 25);
            DateTime newYearsDay = new DateTime(2019, 1, 1);

            TimeSpan span = newYearsDay - chrismas;
            //TimeSpan span = newYearsDay.Subtract(chrismas);

            Console.WriteLine("크리마스와 1월 1일의 시간 간격");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.Days);
            Console.WriteLine("{0,14} hours", span.Hours);
            Console.WriteLine("{0,14} minutes", span.Minutes);
            Console.WriteLine("{0,14} secondes", span.Seconds);
            Console.WriteLine("{0,14} milliseconds", span.Milliseconds);

            Console.WriteLine("또는");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.TotalDays);
            Console.WriteLine("{0,14} hours", span.TotalHours);
            Console.WriteLine("{0,14} minutes", span.TotalMinutes);
            Console.WriteLine("{0,14} secondes", span.TotalSeconds);
            Console.WriteLine("{0,14} milliseconds", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);


        }
    }
}
