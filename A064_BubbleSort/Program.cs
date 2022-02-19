using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A064_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArrya(v);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    if ( v[j] >v[j+1])
                    {
                        int t = v[j];
                        v[j] = v[j+1];
                        v[j+1] = t;
                    }
                PrintArrya(v);
            }
        }
        private static void PrintArrya( int[] v )
        {
            foreach (var i in v)
                Console.Write("{0, 5}", i);
            Console.WriteLine();
        }
    }
}
