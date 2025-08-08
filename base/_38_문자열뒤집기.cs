using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        answer+=my_string.Substring(0,s);
        string st= my_string.Substring(s,e-s+1);
        for(int i=st.Length-1;i>=0;i--){
            answer+=st[i];
        }
        int length = my_string.Length;
        answer+=my_string.Substring(e+1,length-e-1);
        return answer;
    }
}

//다른사람 풀이 ->array로 바꾸어서 해당 인덱스만 바꿈..!대박 왜 난 생각못했지 
using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        char[] chr = my_string.ToCharArray();
        Array.Reverse(chr,s,e-s+1);
        return new string(chr);
    }
}
