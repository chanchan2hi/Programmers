using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int a=0;
         List<string> answer = new List<string>();
        for(int i=0; i<my_string.Length;i++){
            answer.Add(my_string.Substring(i,my_string.Length-i));
        }
        if(answer.Contains(is_suffix))a=1;
        return  a;
       
    }
}
