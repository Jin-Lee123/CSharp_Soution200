using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace A107_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artists[] famousArtists =
            {
                new Artists("레오나드로 다빈치", "이타리아",1452  ,1519),
                new Artists("빈센트 반 고흐", "네덜란드",1853  ,1890),
                new Artists("클로드 모네", "프랑스",1840  ,1926),
                new Artists("파블로 피카소", "스페인", 1881 ,1973),
                new Artists("베르메르", "네덜란드",1632 ,1675),
                new Artists("르노아르", "프랑스", 1841 ,1919),
            };

            List<Artists> artitts19C = new List<Artists>();
            foreach ( var artist in famousArtists )
            {
                if (artist.Birth >1800 && artist.Birth <=1900)
                    artitts19C.Add(artist);
            }

            //IComparable를 사용하여 정렬
            artitts19C.Sort();
            Console.WriteLine("19세기 미술가를 탄생 순 정렬 : IComparable");
            foreach(var a in artitts19C)
                Console.WriteLine(a.ToString());
        }
    }

    class Artists : IComparable
    {
        public string Name { get; set; }  
        public string Country { get; set; } 
        public int Birth { get; set; }
        public int Die {  get; set; }

        public Artists(string name, string country, int birth, int die)
        {
            Name = name;
            Country = country;
            Birth = birth;
            Die = die;
        }

        public int CompareTo(object obj)
        {
            Artists a = (Artists)obj;   
            return this.Birth.CompareTo(a.Birth);
        }

        public override string ToString()
        {
            return String.Format(" {0}, {1}, {2}, {3}", Name, Country, Birth, Die); 
        }
    }
}
