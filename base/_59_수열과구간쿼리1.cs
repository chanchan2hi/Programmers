using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
         Array.Copy(arr, answer, arr.Length);
        //2차원 배열은 .Length 하면 a*b를 호출함
        for(int i=0;i<queries.GetLength(0);i++){
            int s=queries[i,0];
            int e=queries[i,1];
            for(int j=s;j<=e;j++){
                    answer[j]++;
            }
            
        }
        return answer;
    }
}
