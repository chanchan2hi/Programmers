using System;

//프로그래머스 코테연습/코딩 기초 트레이닝/대소문자 바꿔서 출력하기
//C#에서 
//C#에서 대소문자 판별 -> isLower,isUpper
//대소문자 변경 ->ToUpper,ToLower 
namespace Programmers
{
    internal class Program
    {
        public static void Main()
        {
            string answer = "";
            string s = Console.ReadLine();
            for (int i = 0;i<s.Length; i++)
            {
                if (char.IsLower(s[i]) == true)
                {
                    answer += char.ToUpper(s[i]);
                }
                else
                {
                    answer += char.ToLower(s[i]);
                }
            }

            Console.WriteLine(answer);
        }
    }
}
