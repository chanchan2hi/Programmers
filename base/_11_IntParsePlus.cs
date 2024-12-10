using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 -더 크게 합치기
//a,b가 주어졌을때 둘이 문자열로 합쳤을때 더 큰 값 
namespace Programmers.Properties
{
    public class Solution
    { 
        public int solution(int a, int b) {
            int answer = 0;
            string a1= a.ToString()+b.ToString();
            string a2= b.ToString()+a.ToString();
            int aa1 = int.Parse(a1);
            int aa2 = int.Parse(a2);
            if (aa1 > aa2) answer = aa1;
            else answer = aa2;
           
            return answer;
            
            //다른 사람 코드
            // int aNum = Int32.Parse($"{a}{b}");
            // int bNum = Int32.Parse($"{b}{a}");
            // return Math.Max(aNum, bNum);
        }
    }
}
