using System;

public class Solution {
    public string[] solution(string[] names) {
        int nLen= names.Length;
        int len=(nLen%5==0)?nLen/5:nLen/5+1; 
        string[] answer = new string[len];
        for(int i=0; i<len;i++){

            answer[i]=names[i*5];
        }
        return answer;
    }
}
