//프로그래머스 코테연습/코딩  트레이닝
//문제: 기초 - 등차수열의 특정한 항만 더하기 
//첫째항 a,공차 ,d인 등차수열에서 include가 true인 항 들만 더한 값 
//include[i] : i+1항 
//C#에서 배열 초기화 하는법 int[] a= new int[4]; , a={1,2,3} 이런 식으로 해야함. 길이 정해줘야해
namespace Programmers.Properties
{
    public class Solution
    {
        public static int solution(int a, int d, bool[] included) {
            int answer = 0;
            int[] solArray=new int[included.Length];
            for (int i = 0; i < included.Length; i++)
            {
                solArray[i] = a+i*d;
            }

            for (int i = 0; i < included.Length; i++)
            {
                if(included[i]==true) answer += solArray[i];
            }
            return answer;
        }
    }
}
    
