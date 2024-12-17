
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int temp;
        
        for(int i = 0; i < queries.GetLength(0); i++) {
            temp = arr[queries[i, 0]];
            arr[queries[i, 0]] = arr[queries[i, 1]];
            arr[queries[i, 1]] = temp;
        }
        
        return arr;
    }
}
