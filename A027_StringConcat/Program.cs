using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = string.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            string strInterploation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterploation);

            string strConcat = string.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = string.Concat(animals);
            Console.WriteLine(s);
            s = string.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}
