using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A084_ExecutionTime
{
    internal class Program
    {
        static int[] f = new int[50];

        static void Main(string[] args)
        {
            Console.WriteLine("피보나치 수열의 n항까지를 출력합니다.");
            Console.Write("n을 입력하세요 : ");

            int n = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();

            f[1] = f[2] = 1;
            for (int i = 3; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];

            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", f[i]);
            Console.WriteLine();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("실행 시간은 {0}ms\n", elapsedMs);

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i <= n; i++)
                Console.Write("{0} ", FiboRecursive(i));
            Console.WriteLine();

            watch.Stop();
            elapsedMs =watch.ElapsedMilliseconds;
            Console.WriteLine("실행 시간은 {0}ms", elapsedMs);

        }
        
        private static int FiboRecursive(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }
    }
}
