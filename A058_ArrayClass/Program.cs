using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A058_ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 };  // 배열을 선언하고 초기화
            printArraay(a);

            int[] b;
            b = (int[])a.Clone();            //배열 복사 방법1
            printArraay(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);     // 배열 복사 방법2
            printArraay(c);

            a.CopyTo(c, 3);                  // 배열 복사 방법3
            printArraay(c);

            Array.Sort(a);                  //오름차순 정렬
            printArraay(a);

            Array.Reverse(a);             //내림차순 정렬
            printArraay(a);

            Array.Clear(a, 0, a.Length);    //배열 초기화
            printArraay(a);
        }
        private static void printArraay(int[] a)
        {
            foreach(var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}
