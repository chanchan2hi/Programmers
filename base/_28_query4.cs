using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 수열과 구간 쿼리 4
//각 쿼리는 [s,e,k] s<=i<=e 인 모든 i에 대해 i가 k의 배수이면 , arr[i]에 1을 더한다 
//step1. s,e,k 를 queries[i,{0,1,2}] 로 표현.
// s = queries[i, 0] , e =queries[i, 1] ,k=queries[i, 2]
//step2.  i %k ==0이면 arr[i]에 1을 더한다! 

namespace Programmers.Properties
{
    public class Solution {
        public int[] solution(int[] arr, int[,] queries)
        {
            for (int j = 0; j < queries.GetLength(0); j++)
            {
                for (int i = queries[j, 0]; i <= queries[j, 1]; i++)
                {
                    if (i%queries[j, 2]==0 ) arr[i] += 1;
                }
                
            }

            return arr;
        }
    }
}

    
