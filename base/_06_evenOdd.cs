using System;

//프로그래머스 코테연습/코딩 기초 트레이닝
//문제: 홀짝 구분하기 
//a를 2로 나누었을때 (%) 나머지가 0이면 짝수, 아니면 홀수로 구현. 
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
            
            if(a%2==0) Console.WriteLine("{0} is even",a);
            else Console.WriteLine("{0} is odd",a);
            
            //다른 사람들 람다식 사용해서  이런식으로 구현 
            //Console.WriteLine(a + " is " + (a % 2 == 0 ? "even" : "odd"));
            
        }
    }
}
