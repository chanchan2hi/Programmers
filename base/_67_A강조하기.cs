using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach(char c in myString){
            if(c=='a'){
                answer += 'A';
            }else if(char.IsUpper(c)){
                answer +=char.ToLower(c);
            }else{
                answer+=c;
            }
        }
        return answer;
    }
}

myString.ToLower().Replace('a', 'A'); <-이거 개지리는데? 생각좀하면좋겠다 
