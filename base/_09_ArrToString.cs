using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 -문자 리스트를 문자열로 변환하기
//
namespace Programmers.Properties
{
    public class Solution
    {  public string solution(string[] arr) {
            string answer = "";
            for(int i=0; i<arr.Length; i++)
                answer+=arr[i].ToString();

        //다른사람 풀이
        //  answer = String.Join("", arr);
        // string answer = string.Concat(arr);
            return answer;
        }
    }
}
