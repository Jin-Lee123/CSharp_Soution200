using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A081_RecursiveSumOfReciprocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1~n까지의 역수의 합을 구합니다. n을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1~{0}까지의 역수의 합 : {1}", n, SumOfReci(n));
        }

        private static double SumOfReci (int n)
        {
            if (n == 1)
                return 1;
            else
                return 1.0 / n + SumOfReci(n - 1);
        }
    }
}
