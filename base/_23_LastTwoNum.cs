//프로그래머스 코테연습/코딩  트레이닝
//문제: 마지막 두 원소 
//배열 초기화 방법 
// int[]answer = new int [숫자];
namespace Programmers.Properties
{
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int len = num_list.Length;
            int[] answer = new int[len+1];
            for(int i = 0; i < num_list.Length; i++)
                answer[i]=num_list[i];
          
            if(num_list[len-1]>num_list[len-2])
                answer[len]=num_list[len-1]-num_list[len-2];
            else
            {
                answer[len] = num_list[len - 1] * 2;
            }
            return answer;
        }
    }
}

    
