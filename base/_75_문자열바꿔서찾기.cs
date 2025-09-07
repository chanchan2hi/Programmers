using System;

public class Solution {
    public int solution(string myString, string pat) {
        string str="";
        foreach(char c in myString){
            if(c=='A')
                str+='B';
            else if (c=='B')
                str +='A';
        }
        if (str.Contains(pat)) return 1;
        else return 0;
    }
}

using System;

public class Solution {
    public int solution(string myString, string pat) 
    {
        myString = myString.Replace("A", "b")
                           .Replace("B", "a");

        return myString.Contains(pat.ToLower()) ? 1 : 0;
    }
}
