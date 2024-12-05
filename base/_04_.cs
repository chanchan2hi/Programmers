using System;

//프로그래머스 코테연습/코딩 기초 트레이닝
//문제: 문자열 붙여서 출력하기 
namespace Programmers
{
    internal class Program
    {
        public static void Main()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];
            
            Console.WriteLine(s1 + s2);
        }
    }
}
