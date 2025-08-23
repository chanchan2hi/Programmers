using System;

//첫 번째 원소가 1번 원소임 -> idx 0이 1 
public class Solution {
    public int solution(int[] num_list) {
        int evenSum=0;
        int oddSum=0;
        int answer = 0;
        for(int i=0;i<num_list.Length;i+=2){
            evenSum += num_list[i];
        }
        for(int i=1;i<num_list.Length;i+=2){
            oddSum +=num_list[i];
        }
        answer = evenSum > oddSum ? evenSum:oddSum;
        return answer;
    }
}
