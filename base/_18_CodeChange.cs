//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 - 코드 처리하기 
//mode가 0일때 : idx가 짝수일 때만 추가
//mode가 1일떄 : idx가 홀수일 때만 추가.
//계속 틀렸는데 그 이유가 code[i]= "1"로 해서 그랬음 왜그런진몰겠음
namespace Programmers.Properties
{
    public class Solution
    {
        public static string solution(string code)
        {
            bool mode = false;
            string answer = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i]=='1') mode=!mode;
                else if((mode==false && i%2==0)||(mode ==true && i%2!=0) )
                answer += code[i];
            }

            return answer.Length == 0 ? "EMPTY" : answer;
        }
    }
}
    
