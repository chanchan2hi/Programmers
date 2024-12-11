using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 - n의 배수 
//num이 n의 배수면 1, 아니면 0 리턴 
//배수 : 나누었을 때 나머지가 0인것 . 
namespace Programmers.Properties
{
    public class Solution
    { 
        public int solution(int num, int n)
        {
            int answer = num % n;
            if (answer == 0) return 1;
            else return 0;
      //람다식으로 하면 
      //int answer = num%n ==0 ? 1:0;
        }
    }
}
