using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 년도를 입력하세요.");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("당신의 띠 : 원숭이");
                    break;
                case 1:
                    Console.WriteLine("당신의 띠 : 닭");
                    break;
                case 2:
                    Console.WriteLine("당신의 띠 : 개");
                    break;
                case 3:
                    Console.WriteLine("당신의 띠 : 돼지");
                    break;
                case 4:
                    Console.WriteLine("당신의 띠 : 쥐");
                    break;
                case 5:
                    Console.WriteLine("당신의 띠 : 소");
                    break;
                case 6:
                    Console.WriteLine("당신의 띠 : 호랑이");
                    break;
                case 7:
                    Console.WriteLine("당신의 띠 : 토끼");
                    break;
                case 8:
                    Console.WriteLine("당신의 띠 : 용");
                    break;
                case 9:
                    Console.WriteLine("당신의 띠 : 뱀");
                    break;
                case 10:
                    Console.WriteLine("당신의 띠 : 말");
                    break;
                case 11:
                    Console.WriteLine("당신의 띠 : 양");
                    break;
                default:
                    Console.WriteLine("잘못입력한건 아닌지~?");
                    break;
            }
        }
    }
}
