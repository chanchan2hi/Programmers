//프로그래머스 코테연습/코딩  트레이닝
//문제: 주사위 게임 2
//Math.Pow(곱할 수, 몇번) : Math.Pow(a,2)
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(int a, int b, int c) {
            int answer = 0;
            if (a != b && a != c && b != c) answer = a + b + c;
            else if (a == b && a == c && b == c)
                answer = (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
            else answer = (a + b + c) * (a * a + b * b + c * c);
            return answer;
        }
    }
}
    
