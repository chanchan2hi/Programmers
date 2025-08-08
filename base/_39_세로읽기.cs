using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        int rows= my_string.Length/m;
        
        for(int i=0;i<rows;i++){
            int index = i *m+(c-1);
            answer+=my_string[index];
        }
        return answer;
    }
}
