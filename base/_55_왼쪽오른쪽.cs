using System;
using System.Linq;
// l,r중 l가 먼저나옴-> l 기준 왼쪽 
//r이 먼저나옴 -> r기존 오른쪽 
//배열의 길이 = LENGTH-R OR L  +1  
//L이먼저냐 R이먼저냐 -> 먼저나오는거 인덱스를 담아 
public class Solution {
    public string[] solution(string[] str_list) {
       for (int i = 0; i < str_list.Length; i++) {
            if (str_list[i] == "l") {
                // "l"을 만나면 왼쪽 부분 반환
                string[] left = new string[i];
                for (int j = 0; j < i; j++) {
                    left[j] = str_list[j];
                }
                return left;
            }
            else if (str_list[i] == "r") {
                // "r"을 만나면 오른쪽 부분 반환
                int rightLen = str_list.Length - i - 1;
                string[] right = new string[rightLen];
                for (int j = 0; j < rightLen; j++) {
                    right[j] = str_list[i + 1 + j];
                }
                return right;
            }
        }
        // "l"과 "r"이 없으면 빈 배열
        return new string[0];
    }
}
