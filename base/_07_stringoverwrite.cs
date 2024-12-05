using System;

//프로그래머스 코테연습/코딩 기초 트레이닝
//문제: 문자열 겹쳐쓰기 
//Remove(startIndex,count(없어도됨));
//Insert(startIndex,추가할 문자열);
//substring(Startindex,endindex) 스트링의 문자열 일부 추출 
namespace Programmers.Properties
{
    public class Solution
    
    {   //원래 문자열, 바꿀문자열,s번째 인덱스부터 바꿀 문자열 길이만큼 바꿈. 
        public static string solution(string my_string, string overwrite_string, int s) {
            string answer = my_string.Remove(s,overwrite_string.Length);
           answer=answer.Insert(s,overwrite_string);
           
           //다른 사람 코드
           // answer = my_string.Remove(s, overwrite_string.Length).Insert(s, overwrite_string);
           //my_string.Substring(0, s) + overwrite_string + my_string.Substring(s + overwrite_string.Length);
            return answer;
        }
        
    }
}
