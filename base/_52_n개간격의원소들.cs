using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
       List<int> arr= new List<int>();
        for(int i=0; i<num_list.Length;i+=n){
            arr.Add(num_list[i]);
            
        }
        return arr.ToArray();
    }
}
