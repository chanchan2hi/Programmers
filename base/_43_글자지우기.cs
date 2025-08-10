//Hashset -> generic에 포함. 중복을 허용하지 않는 집합(set). 어떤 인덱스가 제거 대상인지 빠르게 판단하는 용도로 적합.

using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] indices) {
    
        HashSet<int> removeSet = new HashSet<int>(indices);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++) {
            //removeset에 없는거->살려야함 
            if (!removeSet.Contains(i)) {
                sb.Append(my_string[i]);
            }
        }

        return sb.ToString();
    }
}
