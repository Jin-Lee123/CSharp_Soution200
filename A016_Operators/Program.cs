using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A016_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);
            Console.WriteLine((3 + 4) * 5);
            Console.WriteLine(3 * 4 / 5);
            Console.WriteLine(4 / 5 * 3);

            int a=10,b=20,c;
            Console.WriteLine(c = a + b);
        }
    }
}
