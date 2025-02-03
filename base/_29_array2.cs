using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> result = new List<int>();

        for (int i = l; i <= r; i++) {
            string numStr = i.ToString();
            bool isValid = true;

            foreach (char c in numStr) {
                if (c != '0' && c != '5') {
                    isValid = false;
                    break;
                }
            }

            if (isValid) {
                result.Add(i);
            }
        }

        return result.Count == 0 ? new int[] {-1} : result.ToArray();
    }
}
