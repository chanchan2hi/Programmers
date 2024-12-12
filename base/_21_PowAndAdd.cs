//프로그래머스 코테연습/코딩  트레이닝
//문제: 원소들의 곱과 합 
//Math.Pow(곱할 수, 몇번) : Math.Pow(a,2)
//모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1, 크면 0을 return 
//곱할때! 중요 !!! 초기화값이 1이여야함
namespace Programmers.Properties
{
    public class Solution
    {
        public static int solution(int[] num_list)
        {
            int add = 0;
            int multi = 1;
            for (int i = 0; i < num_list.Length; i++)
            {
                add += num_list[i];
                multi *=num_list[i];
            }
            
            return multi < (add * add) ? 1 : 0;
        }
    }
}
    
