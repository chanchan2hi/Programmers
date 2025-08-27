using System;

public class Solution {
    public int solution(int[] arr) {
        int x = 0;
        
        while (true) {
            int[] tempArr = (int[])arr.Clone();
            bool changed = false;
            
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 50 && arr[i] % 2 == 0) {
                    arr[i] /= 2;
                } else if (arr[i] < 50 && arr[i] % 2 != 0) {
                    arr[i] = arr[i] * 2 + 1;
                }
            }
            
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != tempArr[i]) {
                    changed = true;
                    break;
                }
            }
            
            if (!changed) {
                return x;
            }
            
            x++;
        }
    }
}
