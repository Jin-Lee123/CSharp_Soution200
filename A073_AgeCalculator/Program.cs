using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A073_AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생일을 입력하세요(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split('/');

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            // 올해의 1월 1일부터 오늘까지의 날짜 수
            totalDays += DayOfYear(tYear, tMonth, tDay);

            // 태어난 해의 생일부터 마지막 날까지의 날짜 수
            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for (int year = bYear + 1; year <tYear; year++)
            {
                if (IsLeapYear(year))
                    totalDays += 366;
                else
                    totalDays += 365;
            }
            Console.WriteLine("total days from birth day : {0}일", totalDays);
        }

        //평년을 기준으로 각월의 누적 날짜 수
        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
