//프로그래머스 코테연습/코딩  트레이닝
//문제: 조건 문자열
//문자열(연산자)에 따라 두 수의 크기 비교
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(string ineq, string eq, int n, int m)
        {
            int answer = 0;
            if (ineq.Equals(">"))
            {
                if (eq.Equals("=")) { 
                    if (n > m || n == m)
                    answer = 1;  
                }
                else if (eq.Equals("!"))
                {
                    if (n > m)
                        answer = 1;
                }
            }
            else if (ineq.Equals("<"))
            {
                if (eq.Equals("="))
                {
                    if (n < m || n == m)
                        answer = 1;
                }
                else
                {
                    if (n < m)
                        answer = 1;
                }
            }

            return answer;
        }
    }
}
    
    /*
     * 어떤 분은
     * string ie=ineq+eq;
     * if(ie ==">=") return n>=n? 1;0;
     * if(ie=="<=") return n<=m? 1:0;
     * if(ie==">!") return n>m? 1;0;
     * if(ie =="<!") return n<m? 1;0; 이렇게 가독성 좋게 짜심 나한테 있어선 위에거가 최선이었을듯?
     */
