using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104_AlphabeticalSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");
            lstNames.Sort();
            foreach ( string s in lstNames )
                Console.Write(s+ " ");
            Console.WriteLine();

            string[] arrNames = new string[100];
            arrNames[0] = "dog";
            arrNames[0] = "cow";
            arrNames[0] = "rabbit";
            arrNames[0] = "goat";
            arrNames[0] = "sheep";
            Array.Sort(arrNames);
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();
        }
    }
}
