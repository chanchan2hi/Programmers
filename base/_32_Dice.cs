using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
  //주사위 카운트를 세서 몇개인지 
    public int solution(int a, int b, int c, int d) {
      //딕셔너리 타입의 변수 선언 키: 주사위에서 나온 숫자, 값: 해당 숫자가 나온 횟수 
        var diceCounts = new Dictionary<int, int>();
        foreach (var num in new int[] { a, b, c, d }) {
          //num이 이미 딕셔너리에 존재하는지 확인, 존재한다면 숫자 증가시키고, 존재하지 않는다면 횟수를 1로 초기화 .
            if (diceCounts.ContainsKey(num))
                diceCounts[num]++;
            else
                diceCounts[num] = 1;
        }
        
        // 1. 네 개의 주사위 값이 모두 같은 경우
        if (diceCounts.Count == 1) {
            return 1111 * a; // 모든 값이 같으므로 a 사용
        }
        
        // 2. 세 개의 주사위 값이 같고, 나머지 하나가 다른 경우
        if (diceCounts.Values.Contains(3)) {
            int p = diceCounts.First(x => x.Value == 3).Key;
            int q = diceCounts.First(x => x.Value == 1).Key;
            return (int)Math.Pow(10 * p + q, 2);
        }
        
        // 3. 두 개씩 같은 값이 나온 경우
        if (diceCounts.Count == 2 && diceCounts.Values.All(v => v == 2)) {
            var keys = diceCounts.Keys.ToArray();
            return (keys[0] + keys[1]) * Math.Abs(keys[0] - keys[1]);
        }
        
        // 4. 두 개의 주사위 값이 같고, 나머지 두 개가 각각 다른 경우
        if (diceCounts.Values.Contains(2)) {
            int p = diceCounts.First(x => x.Value == 2).Key;
            var distinctKeys = diceCounts.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
            return distinctKeys[0] * distinctKeys[1];
        }
        
        // 5. 네 개의 주사위 값이 모두 다른 경우
        return new int[] { a, b, c, d }.Min();
    }

    
}
