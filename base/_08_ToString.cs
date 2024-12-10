using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 -문자열 섞기
//두 문자열의 각 문자 앞부터 번갈아가며 등장하게 
namespace Programmers.Properties
{
    public class Solution
    { 
        public string solution(string str1, string str2) {
            string answer = "";
            for (int i = 0; i < str1.Length; i++)
            {
                answer+=str1[i].ToString()+str2[i].ToString();
            }
            return answer;
        }
    }
}
