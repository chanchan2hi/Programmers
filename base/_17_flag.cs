using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: flag에 따라 다른 값 반환하기 
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(int a, int b, bool flag)
        {
            if (flag) return a + b;
            else return a - b;
        }
    }
}
    
