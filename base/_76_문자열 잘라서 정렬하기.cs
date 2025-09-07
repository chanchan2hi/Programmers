using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        // "x"를 기준으로 분리한 뒤, 빈 문자열 제거 후 정렬
        string[] answer = myString
            .Split('x')                     // 'x' 기준으로 자르기
            .Where(s => s.Length > 0)       // 빈 문자열 제거
            .OrderBy(s => s)                // 사전순 정렬
            .ToArray();                     // 배열로 변환

        return answer;
    }
}
public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x');
        Array.Sort(answer);

        List<string> list = new List<string>();

        for(int i=0; i<answer.Length; i++)
        {
            if(!answer[i].Equals("")) list.Add(answer[i]);
        }
        return list.ToArray();
    }
}
