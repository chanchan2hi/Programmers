using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        List<int>answer= new List<int>();
        for(int i=0;i<arr.Length;i++){
           int a= arr[i];
            for( int j=0;j<a;j++){
                answer.Add(a);
            }
        }
       
        return answer.ToArray();
    }
}
