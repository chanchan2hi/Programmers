using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
      int k = end_num - start_num + 1; 
        int[] answer = new int[k]; 
        for (int i = 0; i < k; i++) {
            answer[i] = start_num + i; 
        }
        return answer;
    }
}
