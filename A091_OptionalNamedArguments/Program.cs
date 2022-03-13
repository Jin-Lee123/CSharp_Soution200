using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A091_OptionalNamedArguments
{
    internal class Program
    {
        static int MyPower(int x, int y =2)
        {
            int resule = 1;
            for ( int i = 0; i < y; i++ )
                resule *= x;
            return resule;
        }
        static int Area( int h, int w)
        {
            return h * w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(4, 2));
            Console.WriteLine(MyPower(4));
            Console.WriteLine(MyPower(3,4));

            Console.WriteLine(Area(w:  5, h: 6));
            Console.WriteLine(Area(w: 6, h: 5));

        }
    }
}
