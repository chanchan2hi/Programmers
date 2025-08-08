using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string, string is_prefix) {
        
        List<string> answer = new List<string>();
        for(int i=0; i<my_string.Length;i++){
            answer.Add(my_string.Substring(0,i));
        }
        int  a=0;
        if(answer.Contains(is_prefix))a=1;
       
        return a;
    }
}
