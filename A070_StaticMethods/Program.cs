using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A070_StaticMethods
{
    class Methods
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30, c=20;
            Methods x = new Methods();
            Console.WriteLine("가장 큰 수는 {0}", x.Larger(x.Larger(a, b), c));
        }
        private int Larger (int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
