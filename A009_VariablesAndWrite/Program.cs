using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2);  //에러 발생
            Console.WriteLine(v1.ToString() + "," + v2.ToString());  //두 개 변수 삾을 각가 문자열로 바꾸어 연결해서 하나의 문자열로 출력하는 방법
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
        }
    }
}