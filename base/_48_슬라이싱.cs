using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        var list = new List<int>();

        // 첫 번째 구간
        int a1 = intervals[0, 0];
        int b1 = intervals[0, 1];
        for (int i = a1; i <= b1; i++)
        {
            list.Add(arr[i]);
        }

        // 두 번째 구간
        int a2 = intervals[1, 0];
        int b2 = intervals[1, 1];
        for (int i = a2; i <= b2; i++)
        {
            list.Add(arr[i]);
        }

        return list.ToArray();
    }
}
