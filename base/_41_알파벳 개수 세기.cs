using System;

// 대문자 일때 'A'의 아스키코드 65 , 소문자 일때 'a'의 아스키 코드 만큼 빼서 하면 인덱스값이 나옴 
public class Solution {
    public int[] solution(string my_string) {
        int[] result = new int[52];

        foreach (char c in my_string) {
            if (c >= 'A' && c <= 'Z') {
                result[c - 'A']++;
            }
            else if (c >= 'a' && c <= 'z') {
                result[26 + (c - 'a')]++;
            }
        }

        return result;
    }
}
