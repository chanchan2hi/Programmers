using System;

public class Solution {
    public int solution(string binomial) {
        string[]st=binomial.Split(' ');
        int a=int.Parse(st[0]);
        string op= st[1];
        int b=int.Parse(st[2]);
        int answer = 0;
        switch(op){
            case "+":
                answer=a+b;
                break;
            case "-":
                answer=a-b;
                break;
            case "*":
                answer=a*b;
                break;
                
        }
        return answer;
    }
}
