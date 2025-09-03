using System;

public class Solution {
    public int[] solution(string myString) {
        string[]lst = myString.Split("x");
        int[]answer = new int[lst.Length];
        for(int i=0;i<lst.Length;i++){
            answer[i]=lst[i].Length;
        }
        return answer;
    }
}
