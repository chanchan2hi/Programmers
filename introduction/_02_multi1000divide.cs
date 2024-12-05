using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 입문 - 두 수의 나눗셈 
namespace Programmers.Properties
{
    public class Solution {
        public static int solution(int num1, int num2) {
            int answer = 1000*num1/num2;
           // return (int)((float)num1 / num2 * 1000); 다른사람은 이렇게 형변환 했더라..
            return answer;
        }
    }
  
}
