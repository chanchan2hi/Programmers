using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 - 두 수의 연산값 비교하기 
//a,b가 주어졌을때 둘이 문자열로 합쳤을때 더 큰 값 vs 2ab 
namespace Programmers.Properties
{
    public class Solution
    { 
        public int solution(int a, int b) {
            
             int aNum = Int32.Parse($"{a}{b}");
             return Math.Max(aNum, a * b * 2);
        }
    }
}
