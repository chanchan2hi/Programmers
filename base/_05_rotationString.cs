using System;

//프로그래머스 코테연습/코딩 기초 트레이닝
//문제: 문자열 돌리기 
//나는 for문을 사용했는데 다른방법이있나?
namespace Programmers
{
    internal class Program
    {
        public static void Main()
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
