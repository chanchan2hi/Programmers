using System;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int l=0;int r=arr.Length-1;  //현재 남아있는 구간[l,r]
        for(int i=0; i<query.Length;i++){
            if(i%2==0){
                //짝수: 뒤를 자른다 
                r=l+query[i];
            }else{//홀수:앞을 자른다
                l=l+query[i];
            }
        }
        int len = r-l+1;
        int[] answer= new int[len];
        Array.Copy(arr,l,answer,0,len);
        return answer;
    }
}
