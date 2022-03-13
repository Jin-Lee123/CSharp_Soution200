using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A089_MethodArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine("Value : {0}", a);

            int b = 3;
            Sqr( ref b );
            Console.WriteLine("Value : {0}", b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out : {0} {1}", name, id);
        }

        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr (ref int x)
        {
            x = x * x;
        }

        static void GetName(out string name, out int id)
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Id : ");
            id = int.Parse(Console.ReadLine());
        }
    }
}
