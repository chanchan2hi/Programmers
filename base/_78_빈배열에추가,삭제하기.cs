using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
         List<int>answer= new List<int>();
        for(int i=0;i<flag.Length;i++){
            if(flag[i]) {
                int a= arr[i];
                for(int j=0;j<a*2;j++){
                    answer.Add(a);
                }
            }
            else{
                int a= arr[i];
                for(int j=0;j<a;j++){
                   if (answer.Count > 0) {
                        answer.RemoveAt(answer.Count - 1);
                    }
                }
            }
        }
        return answer.ToArray();
    }
}
