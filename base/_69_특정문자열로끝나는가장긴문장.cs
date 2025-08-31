using System;

public class Solution {
    public string solution(string myString, string pat) {
      //pat이 마지막으로 나타나는 인덱스를 찾음 pat이 나타나는 시작인덱스임!
        int lastIndex= myString.LastIndexOf(pat);
        //pat의 시작인덱스+pat의길이 해야 원래길이나옴 
        string answer= myString.Substring(0,lastIndex+pat.Length);
        return answer;
    }
}
