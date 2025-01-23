int[] answer = new int[queries.GetLength(0)];
        int min;
        bool isnone;
        
        for (int i = 0; i < queries.GetLength(0); i++) {
            isnone = true;
            min = -2;
            
            for (int j = queries[i, 0]; j <= queries[i, 1]; j++) {
                if (arr[j] > queries[i, 2]) {
                    if (arr[j] < min || min == -2) {
                        if (isnone) {
                            isnone = false;
                        }
                        min = arr[j];
                    }
                }
            }
            
            answer[i] = (isnone) ? -1 : min;
        }
        
        return answer;
