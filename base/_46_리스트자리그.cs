using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];

        switch (n)
        {
            case 1:
                return num_list.Take(b + 1).ToArray(); // 0 ~ b
            case 2:
                return num_list.Skip(a).ToArray();     // a ~ 끝
            case 3:
                return num_list.Skip(a).Take(b - a + 1).ToArray(); // a ~ b
            case 4:
                return num_list.Skip(a).Take(b - a + 1).Where((x, i) => i % c == 0).ToArray(); // a ~ b, 간격 c
            default:
                return new int[0];
        }
    }
}
