using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A112_Indexer
{
    class MyCollection<T>
    {
        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = new MyCollection<string>();
            myString[0] = "Hello, World!";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexer!";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(myString[i]);
        }
    }
}
