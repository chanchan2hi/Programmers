using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 수 조작하기2
// numLog라는 정수 배열 입력받아서  거기있는 수로 wasd 조작 뭐했는지 유추하기 
// 정수->w:+1 s:-1 ;d:+10; a:-10
//문자열 뒤집기
//n번째-n-1번쨰 해서 나온 수만큼을 문자열에 더해주었다.
//String을 리버스 하려면..Array로 형변환 해서 리버스 해야한다. 

namespace Programmers.Properties
{
    public class Solution
    {
        public static string solution(int[] numLog)
        {
            string answer = "";
            for (int i = numLog.Length - 1; i >= 1; i--)
            {
                if (numLog[i] - numLog[i - 1] == 10) answer += 'd';
                if (numLog[i] - numLog[i - 1] == -10) answer += 'a';
                if (numLog[i] - numLog[i - 1] == 1) answer += 'w';
                if (numLog[i] - numLog[i - 1] == -1) answer += 's';
                
            }
            string answer2= new string(answer.Reverse().ToArray());
            //이렇게 했는데 왜 코테연습장에서는 에러가뜨지? 콘솔에선잘된다 -> 콘솔에서 Linq안해서그래
           
            
            return answer2 ;
        }
    }
}

    
