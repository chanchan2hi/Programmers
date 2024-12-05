using System;

//프로그래머스 코테연습/코딩 기초 트레이닝
//문제: 덧셈식 출력하기
//공백 기준으로 input 분리하기 : Console.ReadLine().Split(' '); 
//형변환 하는법: Parse메서드 사용. int.Parse(num);
namespace Programmers
{
    internal class Program
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine("{0} + {1} = {2}", a,b,a + b);
        }
    }
}
