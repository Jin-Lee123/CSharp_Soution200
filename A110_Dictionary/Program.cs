using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A110_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            colorTable.Add("Red", "빨간색");
            colorTable.Add("Green", "초록색");
            colorTable.Add("Blue", "파란색");

            foreach(var v in colorTable)
                Console.WriteLine("colorTable[{0}] = {1}", v.Key, v.Value);

            try
            {
                colorTable.Add("Red", "빨강");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Yellow => {0}", colorTable["Yellow"]);
            }
            catch(KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n" + colorTable["Red"]);
            Console.WriteLine(colorTable["Green"]);
            Console.WriteLine(colorTable["Blue"]);

        }
    }
}
