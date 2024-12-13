using System;
using System.Diagnostics;
using System.IO.Pipes;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 수 조작하기1
// control:wsda , w:+1 s:-1 ;d:+10; a:-10
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(int n, string control) {
            int answer = n;
            for (int i = 0; i < control.Length; i++)
            {
                if (control[i].Equals('w')) answer += 1;
                if (control[i].Equals('s')) answer -= 1;
                if (control[i].Equals('d')) answer += 10;
                if (control[i].Equals('a')) answer -= 10;
            }
            return answer;
        }
    }
}

    
