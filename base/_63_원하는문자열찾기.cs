using System;

//c#에서 string.ToLower(), string.ToUpper(); -> 대소문자 변환 
//string.Contains() 포함하냐? 
public class Solution {
    public int solution(string myString, string pat) {
        string lowerMyString = myString.ToLower();
        string lowerPat = pat.ToLower();

        if (lowerMyString.Contains(lowerPat)) {
            return 1;
        } else {
            return 0;
        }
    }
}
