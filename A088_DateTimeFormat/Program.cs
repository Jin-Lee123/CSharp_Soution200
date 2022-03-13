using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A088_DateTimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime todya = DateTime.Now;

            Console.WriteLine(todya.ToString("yyyy년 MM월 dd일"));
            Console.WriteLine(String.Format("{0:yyyy년 MM월 dd일}", todya));
            Console.WriteLine(todya.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));

            // d : 축약된 날짜 형식
            Console.WriteLine("d : " + todya.ToString("d"));
            // D : 긴 날짜 형식
            Console.WriteLine("D : " + String.Format("{0:D}", todya));
            // t :  축약된 시간
            Console.WriteLine("t : " + String.Format("{0:t}", todya));
            // T : 긴 시간 형식
            Console.WriteLine("T : " + String.Format("{0:T}", todya));
            // g : 일반 날짜 및 시간(초생략)
            Console.WriteLine("g : " + String.Format("{0:g}", todya));
            // G : 일반 날짜 및 시간
            Console.WriteLine("G : " + String.Format("{0:G}", todya));
            // f : Full 날짜 및 시간 (초 생략)
            Console.WriteLine("f : " + String.Format("{0:f}", todya));
            // F : Full 날짜 및 시간
            Console.WriteLine("F : " + String.Format("{0:F}", todya));
            // s : ISO 8601 표준 (밀리초 생략)
            Console.WriteLine("s : " + String.Format("{0:s}", todya));
            // o : ISO 8601 표쥰
            Console.WriteLine("o : " + String.Format("{0:o}", todya));
            // r : UTD로 표시
            Console.WriteLine("r : " + String.Format("{0:r}", todya));
            // u : UTC로 출력
            Console.WriteLine("u : " + String.Format("{0:u}", todya));
        }
    }
}
