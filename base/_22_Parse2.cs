//프로그래머스 코테연습/코딩  트레이닝
//문제: 이어 붙인 수 
namespace Programmers.Properties
{
    public class Solution
    {
        public static int solution(int[] num_list)
        {
            string odd="";
            string even="";
            for (int i = 0; i < num_list.Length; i++)
            {
                if(num_list[i]%2==0)
                    even += num_list[i].ToString();
                else
                    odd += num_list[i].ToString();
                }
            return (int.Parse(even)+int.Parse(odd));
            }

        }
    }
