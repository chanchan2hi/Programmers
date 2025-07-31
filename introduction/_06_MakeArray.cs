using System;
using System.Collections.Generic;

//C# 자르기 : s번 인덱스에서 길이 l 자르기 -> Substring(s,l);
//파싱 : int.Parse(substr)..
//List -> Array = List.ToArray();
public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int>answer=new List<int>();
        for(int i=0;i<intStrs.Length;i++){
            string substr = intStrs[i].Substring(s,l);
            int num = int.Parse(substr);
            if(num>k){
                answer.Add(num);
            }
        }
        
        return answer.ToArray();
    }
}
