using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A112_LinqToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstData = new List<int> { 123, 456, 132, 96, 13, 456, 321 };
            Print("Data: ", lstData);

            List<int> lstOdd = new List<int>();
            lstOdd = SelectOddAndSort(lstData);
            Print("Orderd Odd: ", lstOdd);

            int[] arrEvne;
            arrEvne = SelectEvenAndSort(lstData);
            Print("Ordered Even : ", arrEvne);

        }
        private static List<int> SelectOddAndSort(List<int> lstData)
        {
            return (from item in lstData
                    where item % 2 == 1
                    orderby item
                    select item).ToList<int>();
        }
        private static int[] SelectEvenAndSort(List<int> lstData)
        {
            return (from item in lstData
                    where item % 2 ==0
                    orderby item
                    select item).ToArray<int>();
        }
        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach(var i in data)
                Console.Write(" "+i);
            Console.WriteLine();
        }
    }
}
