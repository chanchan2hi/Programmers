using System;
using System.Collections.Generic; //리스트쓰려면 제네릭 유징 
//문제: 콜라츠 수열 만들기
//x가 짝수: 2로 나눈다
//x가 홀수:3*x+1로 바꾼다 
//를 반복하면 반드시 x가 1로 수렴하는가? 
//동적으로 배열 크기 조정해야하는데.._> 리스트를 사용! 
public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
       answer.Add(n); //초기값 
        //for문으로 사용하고 싶었는데 , 
        // 콜라츠 수열-> 일종의 '재귀문' for보다는 while이 적합. 
        while(n!=1){
            if(n%2==0) {
                n=n/2;
            }
            else{
                n=n*3+1;
                }
            answer.Add(n);
      
      
    }
          return answer.ToArray(); //배열로 변환 후 리턴하기 
}
}
