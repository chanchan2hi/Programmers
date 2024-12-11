using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 홀짝에 따라 다른 값 반환하기 
//n이 홀수라면  n이하의 모든 홀수의 정수 합 return
//n이 짝수라면 n 이하의 짝수인 모든 짝수의 정수의 제곱의 합 return 
// 홀수,짝수의 합을 구해야 했ㄱ 때문에 for문이 2씩 늘어나도록 함 
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            if (n % 2 != 0)
            {
                for (int i = 1; i <= n; i+=2)
                    answer += i;
            }
            else
            {
                for (int i = 2; i <= n; i+=2)
                    answer += i * i;
            }

            return answer;
        }
    }
}
    
