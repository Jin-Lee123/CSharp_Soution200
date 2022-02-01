using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A042_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키를 입력하세요(cm) : ");
            double height = double.Parse(Console.ReadLine()); ;
            height /= 100;

            Console.Write("체중을 입력하세요(kg) : ");
            double weigth = double.Parse(Console.ReadLine());
            double bmi = weigth /(height*height);

            string comment = null;
            if (bmi < 20)
                comment = " 저체중";
            else if (bmi < 25)
                comment = "정상체중";
            else if (bmi < 30)
                comment = "경도비만";
            else if (bmi < 40)
                comment = "비만";
            else
                comment = "고도 비만";

            Console.WriteLine("BMI={0:F1}, \"{1}\"입니다", bmi, comment);
        }
    }
}
