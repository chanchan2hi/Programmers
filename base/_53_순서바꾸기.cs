using System;
using System.Collections.Generic;
//l: 1~n 길이 length-l:n~끝 길이 
public class Solution {
    public int[] solution(int[] num_list, int n) {
         List<int> arr= new List<int>();
        //step1. n~끝 까지의 원소를 리스트에 담음
        for(int i=n;i<num_list.Length;i++)
            arr.Add(num_list[i]);
        //step2. 1~n까지의 원소를 리스트에 담음 
        for(int i=0;i<n;i++){
            arr.Add(num_list[i]);
        }
        
        return arr.ToArray();
    }
}
