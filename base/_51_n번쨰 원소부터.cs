using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int len = num_list.Length-n+1;
        int[] answer = new int[len];
        for(int i=0;i<len;i++){
            answer[i]= num_list[n-1+i];
        }
        return answer;
    }
}
