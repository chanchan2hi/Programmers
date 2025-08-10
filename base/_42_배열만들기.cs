using System;

public class Solution {
    public int[] solution(int n, int k) {
        int l= n/k;
        int[] answer = new int[l];
        for(int i=0;i<l;i++){
            answer[i]=k*(i+1);
        }
        return answer;
    }
}
