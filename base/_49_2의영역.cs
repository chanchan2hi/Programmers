using System;

public class Solution {
    public int[] solution(int[] arr) {
        int firstIndex = -1;
        int lastIndex = -1;

        // 2의 첫 번째, 마지막 위치 찾기
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == 2) {
                if (firstIndex == -1) firstIndex = i; // 첫 번째 발견
                lastIndex = i; // 마지막 발견 계속 갱신
            }
        }

        // 2가 없으면 [-1] 반환
        if (firstIndex == -1) {
            return new int[] { -1 };
        }

        // 부분 배열 길이 계산
        int length = lastIndex - firstIndex + 1;
        int[] result = new int[length];

        // 부분 배열 복사
        for (int i = 0; i < length; i++) {
            result[i] = arr[firstIndex + i];
        }

        return result;
    }
}
