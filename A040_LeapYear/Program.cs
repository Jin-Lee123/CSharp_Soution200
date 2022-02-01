using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A040_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("년도를 입력하세요: ");
            int year = int .Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);

            if (DateTime.IsLeapYear(year))
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);

        }
    }
}
