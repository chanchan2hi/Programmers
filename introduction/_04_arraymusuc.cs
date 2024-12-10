using System;

//프로그래머스 코테연습/코딩  트레이닝
//문제: 입문 -머쓱이보다 키 큰 사람 
//배열에서 자신보다 큰 수의 갯수 리턴 
namespace Programmers.Properties
{
    public class Solution
    {
        public int solution(int[] array, int height) {
            int answer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > height) answer++;
            }
            return answer;
        }

    }
}
